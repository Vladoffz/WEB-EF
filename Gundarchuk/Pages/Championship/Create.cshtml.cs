using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Gundarchuk.Data;
using Gundarchuk.Models;

namespace Gundarchuk.Pages.Championship
{
    public class CreateModel : PageModel
    {
        private readonly Gundarchuk.Data.GundarchukContext _context;

        public CreateModel(Gundarchuk.Data.GundarchukContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Models.Championship Championship { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Championship.Add(Championship);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
