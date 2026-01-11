using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Groovy.Domain
{
    public class Recommendation : BaseDomainModel
    {
        [Required]
        public string? AppUserId { get; set; } = string.Empty;

        [Required]
        public DateTime GeneratedAt { get; set; } = DateTime.UtcNow;

        [Required, StringLength(80)]
        public string AlgorithmUsed { get; set; } = "GroovyV1";

        // Optional: store user’s top-3 inputs as JSON/text
        [StringLength(2000)]
        public string? SeedInput { get; set; }

        // Navigation
        public ICollection<RecommendationSong> RecommendationSongs { get; set; } = new List<RecommendationSong>();
    }
}
