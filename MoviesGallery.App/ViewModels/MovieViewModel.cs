using Microsoft.AspNetCore.Http;

namespace MoviesGallery.App.ViewModels
{
    public class MovieViewModel
    {
        public long Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int ReleaseYear { get; set; }

        public string Director { get; set; }

        public IFormFile Image { get; set; } = null;
    }
}
