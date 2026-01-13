using Groovy.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Drawing;

namespace Groovy.Configurations.Entities
{
    public class ArtistSeed : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder.HasData(
                new Artist
                {
                    Id = 1,
                    Name = "Michael Jackson",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Artist
                {
                    Id = 2,
                    Name = "Madonna",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
);

        }
    }
}
