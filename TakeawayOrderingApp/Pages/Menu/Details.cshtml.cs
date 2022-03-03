#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TakeawayOrderingApp.Data;

namespace TakeawayOrderingApp.Models
{
    public class DetailsModel : PageModel
    {
        private readonly TakeawayOrderingApp.Data.ApplicationDbContext _context;

        public DetailsModel(TakeawayOrderingApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public MenuItem MenuItem { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MenuItem = await _context.MenuItem
                .Include(m => m.Category).FirstOrDefaultAsync(m => m.Id == id);

            if (MenuItem == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
