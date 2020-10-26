using Microsoft.AspNetCore.Mvc;
using MoviesGallery.App.Data;
using MoviesGallery.App.Models;
using System.Threading.Tasks;

namespace MoviesGallery.App.Controllers
{
    public class MovieController : Controller
    {
        private readonly IRepository<Movie> _repo;

        public MovieController(IRepository<Movie> repository)
        {
            _repo = repository;
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
                return View(new Movie());
            }
            else
            {
                var movie = await _repo.GetById(id.Value);
                return View(movie);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Movie movie)
        {
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
    }
}
