using Microsoft.EntityFrameworkCore;

namespace movie_app_list.Models
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options) : base(options) { }
        
        public DbSet<Movie> Movies { get; set; }
    }
}