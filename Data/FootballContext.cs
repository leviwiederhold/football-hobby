using FootballHobby.Models;
using Microsoft.EntityFrameworkCore;

namespace FootballHobby.Data
{
    public class FootballContext : DbContext
    {
        public FootballContext(DbContextOptions<FootballContext> options)
            : base(options)
        {
        }

        public DbSet<Team> Teams => Set<Team>();
        public DbSet<Player> Players => Set<Player>();
    }
}
