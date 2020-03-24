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
    public class DeleteModel : PageModel
    {
        private readonly Gundarchuk.Data.GundarchukContext _context;

        public DeleteModel(Gundarchuk.Data.GundarchukContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ChampionshipCommands = await _context.ChampionshipCommands.FindAsync(id);

            if (ChampionshipCommands != null)
            {
                _context.ChampionshipCommands.Remove(ChampionshipCommands);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
