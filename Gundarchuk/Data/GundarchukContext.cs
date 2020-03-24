using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Gundarchuk.Models;

namespace Gundarchuk.Data
{
    public class GundarchukContext : DbContext
    {
        public GundarchukContext (DbContextOptions<GundarchukContext> options)
            : base(options)
        {
        }

        public DbSet<Gundarchuk.Models.Player> Player { get; set; }

        public DbSet<Gundarchuk.Models.Command> Command { get; set; }

        public DbSet<Gundarchuk.Models.Match> Match { get; set; }

        public DbSet<Gundarchuk.Models.Championship> Championship { get; set; }

        public DbSet<Gundarchuk.Models.ChampionshipCommands> ChampionshipCommands { get; set; }
    }
}
