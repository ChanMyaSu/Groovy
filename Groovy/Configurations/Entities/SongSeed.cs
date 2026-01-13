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
                    Title = "Earrings",
                    DurationSec = 100,
                    Bpm = 120,
                    Energy = 12,
                    MoodTag = "chill",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },

                new Song
                {
                    Title = "4 Minutes",
                    DurationSec = 150,
                    Bpm = 1400,
                    Energy = 12,
                    MoodTag = "happy",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
);

        }
    }
}
