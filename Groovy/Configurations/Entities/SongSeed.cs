using Groovy.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace Groovy.Configurations.Entities
{
    public class SongSeed : IEntityTypeConfiguration<Song>
    {
        public void Configure(EntityTypeBuilder<Song> builder)
        {
            builder.HasData(
                new Song
                {
                    Id = 1,
                    Title = "Midnight Dreams",
                    DurationSec = 245,
                    ReleaseDate = new DateTime(2024, 1, 15),
                    Bpm = 128,
                    Energy = 70,
                    MoodTag = "chill",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },

                new Song
                {
                    Id = 2,
                    Title = "Summer Vibes",
                    DurationSec = 198,
                    ReleaseDate = new DateTime(2023, 6, 20),
                    Bpm = 115,
                    Energy = 85,
                    MoodTag = "happy",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Song
                {
                    Id = 3,
                    Title = "Dark Matter",
                    DurationSec = 312,
                    ReleaseDate = new DateTime(2024, 3, 10),
                    Bpm = 140,
                    Energy = 95,
                    MoodTag = "energetic",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Song
                {
                    Id = 4,
                    Title = "Coffee Shop Jazz",
                    DurationSec = 267,
                    ReleaseDate = new DateTime(2022, 11, 5),
                    Bpm = 90,
                    Energy = 40,
                    MoodTag = "relaxed",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Song
                {
                    Id = 5,
                    Title = "Neon Lights",
                    DurationSec = 223,
                    ReleaseDate = new DateTime(2024, 2, 14),
                    Bpm = 132,
                    Energy = 88,
                    MoodTag = "energetic",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Song
                {
                    Id = 6,
                    Title = "Acoustic Sessions",
                    DurationSec = 189,
                    ReleaseDate = new DateTime(2023, 8, 22),
                    Bpm = 105,
                    Energy = 55,
                    MoodTag = "chill",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Song
                {
                    Id = 7,
                    Title = "Thunder Road",
                    DurationSec = 298,
                    ReleaseDate = new DateTime(2021, 5, 30),
                    Bpm = 145,
                    Energy = 92,
                    MoodTag = "energetic",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Song
                {
                    Id = 8,
                    Title = "Ocean Waves",
                    DurationSec = 334,
                    ReleaseDate = new DateTime(2024, 4, 1),
                    Bpm = 75,
                    Energy = 30,
                    MoodTag = "relaxed",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Song
                {
                    Id = 9,
                    Title = "City Lights",
                    DurationSec = 210,
                    ReleaseDate = new DateTime(2024, 1, 20),
                    Bpm = 95,
                    Energy = 78,
                    MoodTag = "chill",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Song
                {
                    Id = 10,
                    Title = "Morning Glory",
                    DurationSec = 176,
                    ReleaseDate = new DateTime(2023, 7, 15),
                    Bpm = 110,
                    Energy = 65,
                    MoodTag = "happy",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
);

        }
    }
}
