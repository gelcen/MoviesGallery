using System;

namespace MoviesGallery.App.Models
{
    public class Movie
    {
        public long Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int ReleaseYear { get; set; }

        public string Director { get; set; }

        public string Image { get; set; } = "";

        public string Username { get; set; }

        public DateTime AddDate { get; set; } = DateTime.Now;
    }
}
