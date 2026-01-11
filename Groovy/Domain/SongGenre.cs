

namespace Groovy.Domain
{
    public class SongGenre
    {
        public int SongId { get; set; }
        public int GenreId { get; set; }

        // Navigation
        public Song? Song { get; set; }
        public Genre? Genre { get; set; }
    }
}
