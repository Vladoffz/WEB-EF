using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gundarchuk.Models
{
    public class Championship
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ChampionshipCommands ChampionshipCommands;
        public Match Match;
    }
}
