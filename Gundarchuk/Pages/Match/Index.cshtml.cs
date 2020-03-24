using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Gundarchuk.Data;
using Gundarchuk.Models;

namespace Gundarchuk.Pages.Match
{
    public class IndexModel : PageModel
    {
        private readonly Gundarchuk.Data.GundarchukContext _context;

        public IndexModel(Gundarchuk.Data.GundarchukContext context)
        {
            _context = context;
        }

        public IList<Models.Match> Match { get;set; }

        public async Task OnGetAsync()
        {
            Match = await _context.Match.ToListAsync();
        }
    }
}
