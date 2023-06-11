using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ColectieJocuriVideo.Data;
using System;
using System.Linq;

namespace ColectieJocuriVideo.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ColectieJocuriVideoContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ColectieJocuriVideoContext>>()))
            {
                // Look for any games or reviews.
                if (context.Game.Any() && context.Review.Any())
                {
                    return;   // DB has been seeded
                }

                context.Game.AddRange(
                    new Game
                    {
                        Title = "Fortnite",
                        ReleaseDate = DateTime.Parse("2017-7-21"),
                        Genre = "Battle Royale",
                        Price = 25.70M,
                        Publisher = "Epic Games"
                    },

                    new Game
                    {
                        Title = "God of War",
                        ReleaseDate = DateTime.Parse("2018-4-4"),
                        Genre = "Action",
                        Price = 19.90M,
                        Publisher = "SCE Santa Monica Studio"
                    },

                    new Game
                    {
                        Title = "World of Warcraft",
                        ReleaseDate = DateTime.Parse("2004-11-23"),
                        Genre = "Multiplayer",
                        Price = 15.50M,
                        Publisher = "Blizzard Entertainment"
                    },

                    new Game
                    {
                        Title = "Red Dead Redemption 2",
                        ReleaseDate = DateTime.Parse("2018-10-26"),
                        Genre = "Multiplayer",
                        Price = 19.90M,
                        Publisher = "Rockstar Games"
                    },

                    new Game
                    {
                        Title = "The Last of Us",
                        ReleaseDate = DateTime.Parse("2013-6-3"),
                        Genre = "Action",
                        Price = 33.90M,
                        Publisher = "Naughty Dog"
                    },

                    new Game
                    {
                        Title = "Overwatch",
                        ReleaseDate = DateTime.Parse("2016-5-12"),
                        Genre = "Shooter",
                        Price = 33.30M,
                        Publisher = "Blizzard Entertainment"
                    }
                );
                context.SaveChanges();

                context.Review.AddRange(
                    new Review { GameID = 1, Name = "John", Message = "Good game!", Date = DateTime.Parse("2023-06-11") },
                    new Review { GameID = 1, Name = "Kelly", Message = "Nice graphics!", Date = DateTime.Parse("2023-06-10") }
                );

                context.SaveChanges();
            }
        }
    }
}