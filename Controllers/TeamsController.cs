using Microsoft.AspNetCore.Mvc;

namespace FootballHobby.Controllers
{
    public class TeamsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
