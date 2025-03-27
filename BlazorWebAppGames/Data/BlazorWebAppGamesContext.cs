using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorWebAppGames.Models;

namespace BlazorWebAppGames.Data
{
    public class BlazorWebAppGamesContext : DbContext
    {
        public BlazorWebAppGamesContext (DbContextOptions<BlazorWebAppGamesContext> options)
            : base(options)
        {
        }

        public DbSet<BlazorWebAppGames.Models.Game> Game { get; set; } = default!;
    }
}
