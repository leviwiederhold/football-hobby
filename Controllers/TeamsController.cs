using FootballHobby.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FootballHobby.Controllers
{
    public class TeamsController : Controller
    {
        private readonly FootballContext _context;

        public TeamsController(FootballContext context)
        {
            _context = context;
        }

        // GET: /Teams
        public async Task<IActionResult> Index()
        {
            var teams = await _context.Teams
                .Include(t => t.Players)
                .ToListAsync();

            return View(teams);
        }
    }
}
