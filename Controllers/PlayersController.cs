using FootballHobby.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FootballHobby.Controllers
{
    public class PlayersController : Controller
    {
        private readonly FootballContext _context;

        public PlayersController(FootballContext context)
        {
            _context = context;
        }

        // GET: /Players
        public async Task<IActionResult> Index()
        {
            var players = await _context.Players
                .Include(p => p.Team)
                .ToListAsync();

            return View(players);
        }
    }
}
