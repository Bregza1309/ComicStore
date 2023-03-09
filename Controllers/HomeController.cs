using ComicStore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ComicStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index()
        {
            ViewData["currentPage"] = "Home";
            return View();
        }
        [HttpGet]
        public IActionResult Location()
        {
            ViewData["currentPage"] = "Location";
            return View();
        }
        [HttpGet]
        public IActionResult Favourites()
        {
            List<string> favouriteList = new List<string>() 
                                            {"DoctorStrange","Avengers","CaptainMarvel","DoctorStrange","Hulk","X_Men" };
            ViewData["currentPage"] = "Favourites";
            return View(favouriteList);
        }
        [HttpGet]
        public IActionResult About()
        {
            ViewData["Title"] = "AboutUs";
            ViewData["currentPage"] = "AboutUs";
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}