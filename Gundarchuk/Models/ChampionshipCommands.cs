using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gundarchuk.Models
{
    public class ChampionshipCommands
    {
        public int Id { get; set; }
        public Command Command;
        public Championship Championship;
    }
}
