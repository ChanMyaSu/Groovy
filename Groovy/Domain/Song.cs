using System.ComponentModel.DataAnnotations;

namespace Groovy.Domain
{
    public class Song : BaseDomainModel
    {
        [Required, StringLength(160)]
        public string? Title { get; set; } = string.Empty;

        [Range(1, 3600)]
        public int DurationSec { get; set; }

        public DateTime? ReleaseDate { get; set; }

        [StringLength(500)]
        public string? AudioFilePath { get; set; }

        // For recommendation logic
        [Range(40, 250)]
        public int Bpm { get; set; } = 120;

        [Range(0, 100)]
        public int Energy { get; set; } = 50;

        [StringLength(40)]
        public string? MoodTag { get; set; }

        // Navigation
        public ICollection<SongArtist> SongArtists { get; set; } = new List<SongArtist>();
        public ICollection<SongGenre> SongGenres { get; set; } = new List<SongGenre>();
        public ICollection<PlaylistSong> PlaylistSongs { get; set; } = new List<PlaylistSong>();
        public ICollection<ListeningHistory> ListeningHistories { get; set; } = new List<ListeningHistory>();
        public ICollection<RecommendationSong> RecommendationSongs { get; set; } = new List<RecommendationSong>();
    }
}
