using Microsoft.AspNetCore.Mvc;
using MoviesGallery.App.Data;
using MoviesGallery.App.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace MoviesGallery.App.Controllers
{
    public class HomeController : Controller
    {
        private readonly MockRepository _repo;

        public HomeController(MockRepository mockRepository)
        {
            _repo = mockRepository;
        }

        public IActionResult Index()
        {
            var viewModels = new List<HomePageMovieViewModel>();
            foreach (var movie in _repo.Data)
            {
                var vm = new HomePageMovieViewModel(movie.Title,
                    movie.Description);
                viewModels.Add(vm);
            }
            return View(viewModels);
        }
    }
}
