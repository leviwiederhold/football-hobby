using FootballHobby.Models;
using Microsoft.EntityFrameworkCore;

namespace FootballHobby.Data
{
    public static class SeedData
    {
        public static async Task InitializeAsync(IServiceProvider services)
        {
            using var context = services.GetRequiredService<FootballContext>();

            await context.Database.MigrateAsync();

            if (context.Teams.Any()) return;

            var bengals = new Team
            {
                Name = "Cincinnati Bengals",
                City = "Cincinnati",
                Conference = "AFC",
                Division = "AFC North",
                HeadCoach = "Zac Taylor"
            };

            var saints = new Team
            {
                Name = "New Orleans Saints",
                City = "New Orleans",
                Conference = "NFC",
                Division = "NFC South",
                HeadCoach = "Dennis Allen"
            };

            var dolphins = new Team
            {
                Name = "Miami Dolphins",
                City = "Miami",
                Conference = "AFC",
                Division = "AFC East",
                HeadCoach = "Mike McDaniel"
            };

            await context.Teams.AddRangeAsync(bengals, saints, dolphins);
            await context.SaveChangesAsync();

            var players = new List<Player>
            {
                new Player { Name = "Joe Burrow", Position = "QB", JerseyNumber = 9, TeamId = bengals.Id },
                new Player { Name = "Ja'Marr Chase", Position = "WR", JerseyNumber = 1, TeamId = bengals.Id },

                new Player { Name = "Derek Carr", Position = "QB", JerseyNumber = 4, TeamId = saints.Id },
                new Player { Name = "Alvin Kamara", Position = "RB", JerseyNumber = 41, TeamId = saints.Id },

                new Player { Name = "Tua Tagovailoa", Position = "QB", JerseyNumber = 1, TeamId = dolphins.Id },
                new Player { Name = "Tyreek Hill", Position = "WR", JerseyNumber = 10, TeamId = dolphins.Id }
            };

            await context.Players.AddRangeAsync(players);
            await context.SaveChangesAsync();
        }
    }
}
