using Microsoft.EntityFrameworkCore;

namespace Mission6.Models
{
    public class MovieEntryContext : DbContext
    {
        public MovieEntryContext(DbContextOptions<MovieEntryContext> options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
