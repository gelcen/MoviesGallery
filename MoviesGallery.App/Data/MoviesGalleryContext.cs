using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MoviesGallery.App.Models;

namespace MoviesGallery.App.Data
{
    public class MoviesGalleryContext : IdentityDbContext<IdentityUser>
    {
        public MoviesGalleryContext(
            DbContextOptions<MoviesGalleryContext> options)
            : base(options) { }

        public DbSet<Movie> Movies { get; set; }
    }
}
