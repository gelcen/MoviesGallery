using Microsoft.AspNetCore.Mvc;

namespace MoviesGallery.App.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
    }
}
