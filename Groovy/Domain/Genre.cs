using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Groovy.Domain
{
    public class Genre : BaseDomainModel
    {
        [Required, StringLength(80)]
        public string Name { get; set; } = string.Empty;

        // Navigation
        public ICollection<SongGenre> SongGenres { get; set; } = new List<SongGenre>();
    }
}
