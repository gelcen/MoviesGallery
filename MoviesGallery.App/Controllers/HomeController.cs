using Microsoft.AspNetCore.Mvc;
using MoviesGallery.App.Data;
using MoviesGallery.App.Models;
using MoviesGallery.App.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesGallery.App.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository<Movie> _repo;

        public HomeController(IRepository<Movie> mockRepository)
        {
            _repo = mockRepository;
        }

        public async Task<IActionResult> Index()
        {
            var viewModels = new List<HomePageMovieViewModel>();
            var movies = await _repo.GetAll();
            foreach (var movie in movies)
            {
                var vm = new HomePageMovieViewModel(movie.Title,
                    movie.Description);
                viewModels.Add(vm);
            }
            return View(viewModels);
        }
    }
}
