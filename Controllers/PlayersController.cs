using Microsoft.AspNetCore.Mvc;

namespace FootballHobby.Controllers
{
    public class PlayersController : Controller
    {
        public IActionResult Index() => View();
    }
}
