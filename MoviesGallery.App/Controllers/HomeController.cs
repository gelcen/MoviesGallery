using cloudscribe.Pagination.Models;
using Microsoft.AspNetCore.Mvc;
using MoviesGallery.App.Data;
using MoviesGallery.App.Models;
using MoviesGallery.App.ViewModels;
using System;
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

        public async Task<IActionResult> Index(int pageNumber = 1, int pageSize = 4)
        {
            var viewModels = new List<HomePageMovieViewModel>();
            var pagedMovies = await _repo.GetAllInPage(pageNumber, pageSize);
            foreach (var movie in pagedMovies.Data)
            {
                var vm = new HomePageMovieViewModel(
                    movie.Id,
                    movie.Title,
                    movie.Description);
                viewModels.Add(vm);
            }

            var pagedVm = new PagedResult<HomePageMovieViewModel>()
            {
                Data = viewModels,
                TotalItems = pagedMovies.TotalItems,
                PageNumber = pagedMovies.PageNumber,
                PageSize = pagedMovies.PageSize
            };

            return View(pagedVm);
        }
    }
}
