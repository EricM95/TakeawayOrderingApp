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
    public class IndexModel : PageModel
    {
        private readonly TakeawayOrderingApp.Data.ApplicationDbContext _context;

        public IndexModel(TakeawayOrderingApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<MenuItem> MenuItem { get;set; }

        public async Task OnGetAsync()
        {
            MenuItem = await _context.MenuItem
                .Include(m => m.Category).ToListAsync();
        }
    }
}
