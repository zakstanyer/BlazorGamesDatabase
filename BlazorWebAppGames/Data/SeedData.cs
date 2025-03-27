using Microsoft.EntityFrameworkCore;
using BlazorWebAppGames.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Reflection.Metadata;

namespace BlazorWebAppGames.Data;

public class SeedData
{
    //this only runs when the database is empty

    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new BlazorWebAppGamesContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<BlazorWebAppGamesContext>>());

        if (context == null || context.Game == null)
        {
            throw new NullReferenceException(
                "Null BlazorWebAppGamesContext or Game DbSet");
        }

        if (context.Game.Any())
        {
            //if the database contains entries already, don't seed it
            return;
        }

        context.Game.AddRange(
            new Game
            {
                Title = "Hotel Dusk",
                ReleaseDate = new DateOnly(2007, 1, 22),
                Genre = "Adventure",
                Price = 9.99M,
                Score = "9",
            },
            new Game
            {
                Title = "Final Fantasy X",
                ReleaseDate = new DateOnly(2001, 7, 19),
                Genre = "JRPG",
                Price = 19.99M,
                Score = "10",
            }
            );

        context.SaveChanges();
    }
}
