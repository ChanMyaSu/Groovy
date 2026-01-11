using System.ComponentModel.DataAnnotations;

namespace Groovy.Domain
{
    public class Artist : BaseDomainModel
    {
        [Required, StringLength(120)]
        public string Name { get; set; } = string.Empty;

        // Navigation
        public ICollection<SongArtist> SongArtists { get; set; } = new List<SongArtist>();
    }
}
