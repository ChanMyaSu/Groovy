using Groovy.Configurations.Entities;
using Groovy.Data;
using Groovy.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Groovy.Data
{
    public class GroovyContext(DbContextOptions<GroovyContext> options) : IdentityDbContext<GroovyUser>(options)
    {
        public DbSet<Groovy.Domain.AppUser> AppUser { get; set; } = default!;
        public DbSet<Groovy.Domain.Artist> Artist { get; set; } = default!;
        public DbSet<Groovy.Domain.Genre> Genre { get; set; } = default!;
        public DbSet<Groovy.Domain.Playlist> Playlist { get; set; } = default!;
        public DbSet<Groovy.Domain.Song> Song { get; set; } = default!;
        public DbSet<Groovy.Domain.Recommendation> Recommendation { get; set; } = default!;
        public DbSet<Groovy.Domain.ListeningHistory> ListeningHistory { get; set; } = default!;

        public DbSet<SongArtist> SongArtist { get; set; } = default!;
        public DbSet<SongGenre> SongGenre { get; set; } = default!;
        public DbSet<PlaylistSong> PlaylistSong { get; set; } = default!;
        public DbSet<RecommendationSong> RecommendationSong { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //composite keys of connecting entites

            builder.Entity<SongArtist>()
               .HasKey(x => new { x.SongId, x.ArtistId });

            builder.Entity<SongGenre>()
                .HasKey(x => new { x.SongId, x.GenreId });

            builder.Entity<PlaylistSong>()
                .HasKey(x => new { x.PlaylistId, x.SongId });

            builder.Entity<RecommendationSong>()
                .HasKey(x => new { x.RecommendationId, x.SongId });

            // Relationships
            builder.Entity<SongArtist>()
                .HasOne(sa => sa.Song)
                .WithMany(s => s.SongArtists)
                .HasForeignKey(sa => sa.SongId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<SongArtist>()
                .HasOne(sa => sa.Artist)
                .WithMany(a => a.SongArtists)
                .HasForeignKey(sa => sa.ArtistId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<SongGenre>()
                .HasOne(sg => sg.Song)
                .WithMany(s => s.SongGenres)
                .HasForeignKey(sg => sg.SongId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<SongGenre>()
                .HasOne(sg => sg.Genre)
                .WithMany(g => g.SongGenres)
                .HasForeignKey(sg => sg.GenreId)
                .OnDelete(DeleteBehavior.Cascade);

            //seed data
            builder.ApplyConfiguration(new ArtistSeed());
            builder.ApplyConfiguration(new GenreSeed());
            builder.ApplyConfiguration(new SongSeed());
            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new UserSeed());
            builder.ApplyConfiguration(new UserRoleSeed());

        }

    }
}
