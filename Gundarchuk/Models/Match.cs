using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Gundarchuk.Models
{
    public class Match
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Command Command;
        public int Schet { get; set; }
        [DataType(DataType.Date)]
        public DateTime PlayedDate { get; set; }
        
    }
}
