using System.Text.Json;
using Groovy.Data;
using Groovy.Domain;
using Microsoft.EntityFrameworkCore;

namespace Groovy.Services
{
    public interface IRecommendationService
    {
        Task<Recommendation> GenerateFindMyGrooveAsync(
            string userId,
            List<int> favoriteArtistIds,
            List<int> favoriteGenreIds,
            List<int> favoriteSongIds,
            int desiredCount = 4);
    }

    public class RecommendationService : IRecommendationService
    {
        private readonly IDbContextFactory<GroovyContext> _dbFactory;

        public RecommendationService(IDbContextFactory<GroovyContext> dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<Recommendation> GenerateFindMyGrooveAsync(
            string userId,
            List<int> favoriteArtistIds,
            List<int> favoriteGenreIds,
            List<int> favoriteSongIds,
            int desiredCount = 4)
        {
            favoriteArtistIds = (favoriteArtistIds ?? new()).Distinct().Take(3).ToList();
            favoriteGenreIds = (favoriteGenreIds ?? new()).Distinct().Take(3).ToList();
            favoriteSongIds = (favoriteSongIds ?? new()).Distinct().Take(3).ToList();

            using var db = _dbFactory.CreateDbContext();

            var excluded = new HashSet<int>(favoriteSongIds);

            var alreadyRecommended = await db.RecommendationSong
                .Where(rs => rs.Recommendation!.AppUserId == userId)
                .Select(rs => rs.SongId)
                .Distinct()
                .ToListAsync();

            foreach (var id in alreadyRecommended) excluded.Add(id);

            var seedSongs = await db.Song
                .Where(s => favoriteSongIds.Contains(s.Id))
                .Select(s => new { s.Bpm, s.Energy })
                .ToListAsync();

            var avgBpm = seedSongs.Count > 0 ? seedSongs.Average(x => x.Bpm) : 120;
            var avgEnergy = seedSongs.Count > 0 ? seedSongs.Average(x => x.Energy) : 50;

            var chosen = new List<(Song song, double score)>();

            var targetGenreId = await PickBestGenreAsync(db, favoriteGenreIds, excluded);
            if (targetGenreId != null)
            {
                var genrePicks = await GetTopSongsByGenreAsync(db, targetGenreId.Value, excluded, favoriteArtistIds, favoriteGenreIds, avgBpm, avgEnergy, 2);
                foreach (var pick in genrePicks)
                {
                    chosen.Add(pick);
                    excluded.Add(pick.song.Id);
                }
            }

            var targetArtistId = await PickBestArtistAsync(db, favoriteArtistIds, excluded);
            if (targetArtistId != null)
            {
                var artistPicks = await GetTopSongsByArtistAsync(db, targetArtistId.Value, excluded, favoriteArtistIds, favoriteGenreIds, avgBpm, avgEnergy, 2);
                foreach (var pick in artistPicks)
                {
                    chosen.Add(pick);
                    excluded.Add(pick.song.Id);
                }
            }

            if (chosen.Count < desiredCount)
            {
                var fill = await GetFillSongsAsync(db, excluded, favoriteArtistIds, favoriteGenreIds, favoriteSongIds, avgBpm, avgEnergy, desiredCount - chosen.Count);
                foreach (var pick in fill)
                {
                    chosen.Add(pick);
                    excluded.Add(pick.song.Id);
                }
            }

            var rec = new Recommendation
            {
                AppUserId = userId,
                GeneratedAt = DateTime.UtcNow,
                AlgorithmUsed = "FindMyGrooveV1",
                SeedInput = JsonSerializer.Serialize(new
                {
                    artists = favoriteArtistIds,
                    genres = favoriteGenreIds,
                    songs = favoriteSongIds
                }),
                DateCreated = DateTime.UtcNow,
                DateUpdated = DateTime.UtcNow,
                CreatedBy = userId,
                UpdatedBy = userId
            };

            db.Recommendation.Add(rec);
            await db.SaveChangesAsync();

            var ranked = chosen
                .OrderByDescending(x => x.score)
                .Take(desiredCount)
                .ToList();

            for (int i = 0; i < ranked.Count; i++)
            {
                db.RecommendationSong.Add(new RecommendationSong
                {
                    RecommendationId = rec.Id,
                    SongId = ranked[i].song.Id,
                    RankNum = i + 1,
                    Score = ranked[i].score
                });
            }

            await db.SaveChangesAsync();

            var hydrated = await db.Recommendation
                .Where(r => r.Id == rec.Id)
                .Include(r => r.RecommendationSongs)
                    .ThenInclude(rs => rs.Song)
                        .ThenInclude(s => s!.SongArtists)
                            .ThenInclude(sa => sa.Artist)
                .Include(r => r.RecommendationSongs)
                    .ThenInclude(rs => rs.Song)
                        .ThenInclude(s => s!.SongGenres)
                            .ThenInclude(sg => sg.Genre)
                .FirstAsync();

            return hydrated;
        }

        private static async Task<int?> PickBestGenreAsync(GroovyContext db, List<int> genreIds, HashSet<int> excluded)
        {
            if (genreIds.Count == 0) return null;

            var best = await db.SongGenre
                .Where(sg => genreIds.Contains(sg.GenreId) && !excluded.Contains(sg.SongId))
                .GroupBy(sg => sg.GenreId)
                .Select(g => new { GenreId = g.Key, Count = g.Count() })
                .OrderByDescending(x => x.Count)
                .FirstOrDefaultAsync();

            return best?.GenreId;
        }

        private static async Task<int?> PickBestArtistAsync(GroovyContext db, List<int> artistIds, HashSet<int> excluded)
        {
            if (artistIds.Count == 0) return null;

            var best = await db.SongArtist
                .Where(sa => artistIds.Contains(sa.ArtistId) && !excluded.Contains(sa.SongId))
                .GroupBy(sa => sa.ArtistId)
                .Select(g => new { ArtistId = g.Key, Count = g.Count() })
                .OrderByDescending(x => x.Count)
                .FirstOrDefaultAsync();

            return best?.ArtistId;
        }

        private static async Task<List<(Song song, double score)>> GetTopSongsByGenreAsync(
            GroovyContext db,
            int genreId,
            HashSet<int> excluded,
            List<int> favoriteArtistIds,
            List<int> favoriteGenreIds,
            double avgBpm,
            double avgEnergy,
            int take)
        {
            var songs = await db.Song
                .Where(s => !excluded.Contains(s.Id) && s.SongGenres.Any(g => g.GenreId == genreId))
                .Include(s => s.SongArtists).ThenInclude(sa => sa.Artist)
                .Include(s => s.SongGenres).ThenInclude(sg => sg.Genre)
                .ToListAsync();

            return songs
                .Select(s => (s, ScoreSong(s, favoriteArtistIds, favoriteGenreIds, avgBpm, avgEnergy)))
                .OrderByDescending(x => x.Item2)
                .Take(take)
                .Select(x => (x.s, x.Item2))
                .ToList();
        }

        private static async Task<List<(Song song, double score)>> GetTopSongsByArtistAsync(
            GroovyContext db,
            int artistId,
            HashSet<int> excluded,
            List<int> favoriteArtistIds,
            List<int> favoriteGenreIds,
            double avgBpm,
            double avgEnergy,
            int take)
        {
            var songs = await db.Song
                .Where(s => !excluded.Contains(s.Id) && s.SongArtists.Any(a => a.ArtistId == artistId))
                .Include(s => s.SongArtists).ThenInclude(sa => sa.Artist)
                .Include(s => s.SongGenres).ThenInclude(sg => sg.Genre)
                .ToListAsync();

            return songs
                .Select(s => (s, ScoreSong(s, favoriteArtistIds, favoriteGenreIds, avgBpm, avgEnergy)))
                .OrderByDescending(x => x.Item2)
                .Take(take)
                .Select(x => (x.s, x.Item2))
                .ToList();
        }

        private static async Task<List<(Song song, double score)>> GetFillSongsAsync(
            GroovyContext db,
            HashSet<int> excluded,
            List<int> favoriteArtistIds,
            List<int> favoriteGenreIds,
            List<int> favoriteSongIds,
            double avgBpm,
            double avgEnergy,
            int take)
        {
            var fromSeedArtists = await db.SongArtist
                .Where(sa => favoriteSongIds.Contains(sa.SongId))
                .Select(sa => sa.ArtistId)
                .Distinct()
                .ToListAsync();

            var fromSeedGenres = await db.SongGenre
                .Where(sg => favoriteSongIds.Contains(sg.SongId))
                .Select(sg => sg.GenreId)
                .Distinct()
                .ToListAsync();

            var allArtists = favoriteArtistIds.Concat(fromSeedArtists).Distinct().ToList();
            var allGenres = favoriteGenreIds.Concat(fromSeedGenres).Distinct().ToList();

            var songs = await db.Song
                .Where(s => !excluded.Contains(s.Id) &&
                            (s.SongArtists.Any(a => allArtists.Contains(a.ArtistId)) ||
                             s.SongGenres.Any(g => allGenres.Contains(g.GenreId))))
                .Include(s => s.SongArtists).ThenInclude(sa => sa.Artist)
                .Include(s => s.SongGenres).ThenInclude(sg => sg.Genre)
                .ToListAsync();

            return songs
                .Select(s => (s, ScoreSong(s, favoriteArtistIds, favoriteGenreIds, avgBpm, avgEnergy)))
                .OrderByDescending(x => x.Item2)
                .Take(take)
                .Select(x => (x.s, x.Item2))
                .ToList();
        }

        private static double ScoreSong(Song song, List<int> favoriteArtistIds, List<int> favoriteGenreIds, double avgBpm, double avgEnergy)
        {
            var score = 0.0;

            var songArtistIds = song.SongArtists.Select(x => x.ArtistId).ToHashSet();
            var songGenreIds = song.SongGenres.Select(x => x.GenreId).ToHashSet();

            score += songArtistIds.Intersect(favoriteArtistIds).Count() * 35.0;
            score += songGenreIds.Intersect(favoriteGenreIds).Count() * 25.0;

            score += Math.Max(0, 30.0 - (Math.Abs(song.Bpm - avgBpm) / 2.0));
            score += Math.Max(0, 20.0 - (Math.Abs(song.Energy - avgEnergy) / 3.0));

            if (!string.IsNullOrWhiteSpace(song.MoodTag)) score += 5.0;

            return score;
        }
    }
}
