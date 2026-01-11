using System.ComponentModel.DataAnnotations;

namespace Groovy.Domain
{
    public class Playlist : BaseDomainModel
    {
        [Required, StringLength(120)]
        public string? Name { get; set; } = string.Empty;

        // FK to Identity user
        [Required]
        public string AppUserId { get; set; } = string.Empty;

        // Navigation
        public ICollection<PlaylistSong> PlaylistSongs { get; set; } = new List<PlaylistSong>();
    }
}