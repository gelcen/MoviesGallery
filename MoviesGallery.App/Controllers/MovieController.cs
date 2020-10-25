using Microsoft.AspNetCore.Mvc;
using MoviesGallery.App.Data;
using MoviesGallery.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    }
}
