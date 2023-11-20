using Microsoft.EntityFrameworkCore;
using MovieSense_API.DTO;

namespace MovieSense_API
{
    public class DbManager : DbContext
    {
        private readonly string dbPath = "movie-sense.db";

        public DbSet<Review> Reviews { get; set; }

        public DbManager(DbContextOptions<DbManager> options) : base(options) { 
               
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Review>().HasKey(reviewModel => reviewModel.Id);
        }
    }
}
