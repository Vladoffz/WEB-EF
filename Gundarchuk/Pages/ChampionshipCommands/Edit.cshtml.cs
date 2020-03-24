using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Gundarchuk.Data;
using Gundarchuk.Models;

namespace Gundarchuk.Pages.ChampionshipCommands
{
    public class EditModel : PageModel
    {
        private readonly Gundarchuk.Data.GundarchukContext _context;

        public EditModel(Gundarchuk.Data.GundarchukContext context)
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

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ChampionshipCommands).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChampionshipCommandsExists(ChampionshipCommands.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ChampionshipCommandsExists(int id)
        {
            return _context.ChampionshipCommands.Any(e => e.Id == id);
        }
    }
}
