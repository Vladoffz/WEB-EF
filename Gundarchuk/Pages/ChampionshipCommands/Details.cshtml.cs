using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Gundarchuk.Data;
using Gundarchuk.Models;

namespace Gundarchuk.Pages.ChampionshipCommands
{
    public class DetailsModel : PageModel
    {
        private readonly Gundarchuk.Data.GundarchukContext _context;

        public DetailsModel(Gundarchuk.Data.GundarchukContext context)
        {
            _context = context;
        }

        public Models.ChampionshipCommands ChampionshipCommands { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ChampionshipCommands = await _context.ChampionshipCommands.FirstOrDefaultAsync(m => m.Id == id);

            if (ChampionshipCommands == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
