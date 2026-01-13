namespace Groovy.Domain
{
    public class PlaylistSong
    {
        public int PlaylistId { get; set; }
        public int SongId { get; set; }

        


        // Navigation
        public Playlist? Playlist { get; set; }
        public Song? Song { get; set; }
    }
}
