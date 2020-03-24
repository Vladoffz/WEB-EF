using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Gundarchuk.Data;
using Gundarchuk.Models;

namespace Gundarchuk.Pages.Command
{
    public class DeleteModel : PageModel
    {
        private readonly Gundarchuk.Data.GundarchukContext _context;

        public DeleteModel(Gundarchuk.Data.GundarchukContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Models.Command Command { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Command = await _context.Command.FirstOrDefaultAsync(m => m.Id == id);

            if (Command == null)
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

            Command = await _context.Command.FindAsync(id);

            if (Command != null)
            {
                _context.Command.Remove(Command);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
