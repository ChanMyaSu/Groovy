namespace Groovy.Domain
{
    public class PlaylistSong
    {
        public int PlaylistId { get; set; }
        public int SongId { get; set; }

        // Optional: ordering in playlist
        public int OrderIndex { get; set; } = 0;

        // Navigation
        public Playlist? Playlist { get; set; }
        public Song? Song { get; set; }
    }
}
