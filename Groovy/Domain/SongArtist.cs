
namespace Groovy.Domain
{
    public class SongArtist
    {
        public int SongId { get; set; }
        public int ArtistId { get; set; }

        // Navigation
        public Song? Song { get; set; }
        public Artist? Artist { get; set; }
    }
}
