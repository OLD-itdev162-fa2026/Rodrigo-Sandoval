using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DbSet<WeatherForecast> WeatherForecasts { get; set; }
        public string DbPath { get; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            DbPath = "Blogbox.db";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Data Source={DbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Value converter for DateOnly
            modelBuilder.Entity<WeatherForecast>()
                .Property(e => e.Date)
                .HasConversion(
                    v => v.ToString("yyyy-MM-dd"),
                    v => DateOnly.Parse(v)
                );
        }
    }
}