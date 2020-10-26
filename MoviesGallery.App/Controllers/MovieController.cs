using Microsoft.AspNetCore.Mvc;
using MoviesGallery.App.Data;
using MoviesGallery.App.Data.FileManager;
using MoviesGallery.App.Models;
using MoviesGallery.App.ViewModels;
using System.Threading.Tasks;

namespace MoviesGallery.App.Controllers
{
    public class MovieController : Controller
    {
        private readonly IRepository<Movie> _repo;
        private readonly IFileManager _fileManager;

        public MovieController(IRepository<Movie> repository,
            IFileManager fileManager)
        {
            _repo = repository;
            _fileManager = fileManager;
        }

        public async Task<IActionResult> Detail(long id)
        {
            var movie = await _repo.GetById(id);
            return View(movie);
        }

        [HttpGet]
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
                });
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(MovieViewModel vm)
        {
            var movie = new Movie
            {
                Id = vm.Id,
                Title = vm.Title,
                Director = vm.Director,
                ReleaseYear = vm.ReleaseYear,
                Description = vm.Description,
                Image = await _fileManager.SaveImage(vm.Image)
            };
            if (movie.Id > 0)
            {
                await _repo.Update(movie);
            }
            else
            {
                await _repo.Create(movie);
            }

            return RedirectToAction("Index", "Home");
        }

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
