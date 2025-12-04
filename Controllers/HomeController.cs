using Microsoft.AspNetCore.Mvc;

namespace FootballHobby.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutHobby()
        {
            return View();
        }

        public IActionResult AboutMe()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
