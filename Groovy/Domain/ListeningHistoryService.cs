using Groovy.Data;
using Groovy.Domain;
using Microsoft.EntityFrameworkCore;

namespace Groovy.Services
{
    public interface IListeningHistoryService
    {
        Task RecordPlayAsync(string userId, int songId);
        Task UpdatePlayDurationAsync(int historyId, int durationPercent, bool skipped = false);
        Task<List<ListeningHistory>> GetUserHistoryAsync(string userId, int take = 50);
    }

    public class ListeningHistoryService : IListeningHistoryService
    {
        private readonly IDbContextFactory<GroovyContext> _contextFactory;

        public ListeningHistoryService(IDbContextFactory<GroovyContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task RecordPlayAsync(string userId, int songId)
        {
            using var context = _contextFactory.CreateDbContext();

            var history = new ListeningHistory
            {
                AppUserId = userId,
                SongId = songId,
                ListenedAt = DateTime.UtcNow,
                PlayedDurationPercent = 0,
                Skipped = false,
                DateCreated = DateTime.UtcNow,
                CreatedBy = userId
            };

            context.ListeningHistory.Add(history);
            await context.SaveChangesAsync();
        }

        public async Task UpdatePlayDurationAsync(int historyId, int durationPercent, bool skipped = false)
        {
            using var context = _contextFactory.CreateDbContext();

            var history = await context.ListeningHistory.FindAsync(historyId);
            if (history != null)
            {
                history.PlayedDurationPercent = durationPercent;
                history.Skipped = skipped;
                history.DateUpdated = DateTime.UtcNow;

                await context.SaveChangesAsync();
            }
        }

        public async Task<List<ListeningHistory>> GetUserHistoryAsync(string userId, int take = 50)
        {
            using var context = _contextFactory.CreateDbContext();

            return await context.ListeningHistory
                .Include(h => h.Song)
                .Where(h => h.AppUserId == userId)
                .OrderByDescending(h => h.ListenedAt)
                .Take(take)
                .ToListAsync();
        }
    }
}