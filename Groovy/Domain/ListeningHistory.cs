using System.ComponentModel.DataAnnotations;

namespace Groovy.Domain
{
    public class ListeningHistory : BaseDomainModel
    {
        [Required]
        public string AppUserId { get; set; } = string.Empty;

        [Required]
        public int SongId { get; set; }

        // Changed from PlayedAt to ListenedAt to match your existing code
        [Required]
        public DateTime ListenedAt { get; set; } = DateTime.UtcNow;

        // Changed from CompletionPercent to PlayedDurationPercent
        [Range(0, 100)]
        public int PlayedDurationPercent { get; set; } = 100;

        // Added Skipped property that your code expects
        public bool Skipped { get; set; } = false;

        // Navigation
        public Song? Song { get; set; }
    }
}