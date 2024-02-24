using Microsoft.EntityFrameworkCore;

namespace ExercicesAvancedProgramming.UrlShortener
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options): base(options) { }

        public DbSet<ShortenedUrl> ShortenedUrls { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ShortenedUrl>(modelBuilder =>
            {
                modelBuilder
                    .Property(ShortenedUrl => ShortenedUrl.Code)
                    .HasMaxLength(ShortLinkSettings.Length);

                modelBuilder
                    .HasIndex(ShortenedUrl => ShortenedUrl.Code)
                    .IsUnique();
            });
        }
    }
}
