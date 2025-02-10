using Conference_Website.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Conference_Website.Controllers
{
    //HomeController contain all action related to Home page
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Speaker()
        {
            return View();
        }

        public IActionResult About_the_conference()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
