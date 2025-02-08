using Microsoft.AspNetCore.Mvc;

namespace Conference_Website.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult Organizing_Committee()
        {
            return View();
        }

        public IActionResult Scope_of_Conference()
        {
            return View();
        }

        public IActionResult Editorial_Board()
        {
            return View();
        }

        public IActionResult About_the_conference()
        {
            return View();
        }
    }
}
