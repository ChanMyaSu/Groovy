using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Groovy.Domain;
using Groovy.Configurations.Entities;

namespace Groovy.Data
{
    public class GroovyContext : DbContext
    {
        public GroovyContext (DbContextOptions<GroovyContext> options): base(options)

        {


        }
        


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ArtistSeed());

            //composite keys of connecting entites
            
            builder.Entity<SongArtist>()
               .HasKey(x => new { x.SongId, x.ArtistId });

            builder.Entity<SongGenre>()
                .HasKey(x => new { x.SongId, x.GenreId });

            builder.Entity<PlaylistSong>()
                .HasKey(x => new { x.PlaylistId, x.SongId });

            builder.Entity<RecommendationSong>()
                .HasKey(x => new { x.RecommendationId, x.SongId });
            //seed data
            builder.ApplyConfiguration(new ArtistSeed());
            builder.ApplyConfiguration(new GenreSeed());
            builder.ApplyConfiguration(new SongSeed());

        }


        public DbSet<Groovy.Domain.AppUser> AppUser { get; set; } = default!;
        public DbSet<Groovy.Domain.Artist> Artist { get; set; } = default!;
        public DbSet<Groovy.Domain.Genre> Genre { get; set; } = default!;
        public DbSet<Groovy.Domain.Playlist> Playlist { get; set; } = default!;
        public DbSet<Groovy.Domain.Song> Song { get; set; } = default!;
        public DbSet<Groovy.Domain.Recommendation> Recommendation { get; set; } = default!;
        public DbSet<Groovy.Domain.ListeningHistory> ListeningHistory { get; set; } = default!;
    }
}
