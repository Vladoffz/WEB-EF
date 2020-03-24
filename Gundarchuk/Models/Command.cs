using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace Gundarchuk.Models
{
    public class Command
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public Player Player;
    }
}
