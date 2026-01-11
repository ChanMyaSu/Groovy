using System.ComponentModel.DataAnnotations;

namespace Groovy.Domain
{
    public class RecommendationSong
    {
        public int RecommendationId { get; set; }
        public int SongId { get; set; }

        [Range(0, 1_000_000)]
        public double Score { get; set; } = 0;

        [Range(1, 1000)]
        public int RankNum { get; set; } = 1;

        // Navigation
        public Recommendation? Recommendation { get; set; }
        public Song? Song { get; set; }
    }
}
