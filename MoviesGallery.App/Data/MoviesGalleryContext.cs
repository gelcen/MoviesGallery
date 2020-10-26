using Microsoft.EntityFrameworkCore;
using MoviesGallery.App.Models;

namespace MoviesGallery.App.Data
{
    public class MoviesGalleryContext : DbContext
    {
        public MoviesGalleryContext(
            DbContextOptions<MoviesGalleryContext> options)
            : base(options) { }

        public DbSet<Movie> Movies { get; set; }
    }
}
