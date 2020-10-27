using cloudscribe.Pagination.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviesGallery.App.Data;
using MoviesGallery.App.Data.FileManager;
using MoviesGallery.App.Models;
using MoviesGallery.App.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesGallery.App.Controllers
{
    public class MovieController : Controller
    {
        private readonly IRepository<Movie> _repo;
        private readonly IFileManager _fileManager;
        private readonly IHttpContextAccessor _httpContext;

        public MovieController(IRepository<Movie> repository,
            IFileManager fileManager,
            IHttpContextAccessor httpContext)
        {
            _repo = repository;
            _fileManager = fileManager;
            _httpContext = httpContext;
        }

        public async Task<IActionResult> Detail(long id)
        {
            var movie = await _repo.GetById(id);
            return View(movie);
        }

        [Authorize]
        public async Task<IActionResult> MyMovies(int pageNumber = 1, int pageSize = 4)
        {
            var viewModels = new List<HomePageMovieViewModel>();
            var pagedMovies = await _repo.GetAllInPage(pageNumber, pageSize,
                m => m.Username == _httpContext.HttpContext.User.Identity.Name);
            foreach (var movie in pagedMovies.Data)
            {
                var vm = new HomePageMovieViewModel(
                    movie.Id,
                    movie.Title,
                    movie.Description,
                    movie.Image,
                    movie.Username);
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

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return View(new MovieViewModel());
            }
            else
            {
                var movie = await _repo.GetById(id.Value);
                return View(new MovieViewModel
                {
                    Id = movie.Id,
                    Title = movie.Title,
                    Director = movie.Director,
                    ReleaseYear = movie.ReleaseYear,
                    Description = movie.Description,
                    Username = movie.Username,
                    CurrentImage = movie.Image
                });
            }
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Edit(MovieViewModel vm)
        {
            if (!ModelState.IsValid)
                return View(vm);

            var movie = new Movie
            {
                Id = vm.Id,
                Title = vm.Title,
                Director = vm.Director,
                ReleaseYear = vm.ReleaseYear,
                Description = vm.Description,
                Username = vm.Username
            };

            if (vm.Image == null)
            {
                movie.Image = vm.CurrentImage;
            }
            else
            {
                movie.Image = await _fileManager.SaveImage(vm.Image);
            }

            if (movie.Id > 0)
            {
                await _repo.Update(movie);
            }
            else
            {
                movie.Username = _httpContext.HttpContext.User.Identity.Name;
                await _repo.Create(movie);
            }

            return RedirectToAction("Index", "Home");
        }

        [Authorize]
        public async Task<IActionResult> Remove(long id)
        {
            await _repo.Delete(id);

            return RedirectToAction("Index", "Home");
        }

        [HttpGet("/Image/{image}")]
        public IActionResult Image(string image)
        {
            var mime = image.Substring(image.LastIndexOf('.') + 1);
            return new FileStreamResult(
                _fileManager.ImageStream(image), $"image/{mime}");
        }
    }
}
