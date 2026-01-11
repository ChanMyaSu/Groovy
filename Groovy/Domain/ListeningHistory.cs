using System.ComponentModel.DataAnnotations;

namespace Groovy.Domain
{
    public class ListeningHistory : BaseDomainModel
    {
        [Required]
        public string AppUserId { get; set; } = string.Empty;

        [Required]
        public int SongId { get; set; }

        [Required]
        public DateTime ListenedAt { get; set; } = DateTime.UtcNow;

        [Range(0, 100)]
        public int PlayedDurationPercent { get; set; } = 0;

        public bool Skipped { get; set; } = false;

        // Navigation
        public Song? Song { get; set; }
    }
}