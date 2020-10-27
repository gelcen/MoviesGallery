using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace MoviesGallery.App.ViewModels
{
    public class MovieViewModel
    {
        public long Id { get; set; }

        [Required(ErrorMessage ="Введите название фильма")]
        [Display(Name ="Название")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Введите описание фильма")]
        [Display(Name = "Описание")]
        public string Description { get; set; }

        [Range(1900, 2100, ErrorMessage ="Введите год в диапазоне 1900 до 2100")]
        [Display(Name = "Год выпуска")]
        public int ReleaseYear { get; set; }

        [Required(ErrorMessage = "Введите имя режиссера фильма")]
        [Display(Name = "Режиссер")]
        public string Director { get; set; }

        public string Username { get; set; }

        public string CurrentImage { get; set; } = "";

        public IFormFile Image { get; set; } = null;
    }
}
