using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DemoHms;
using DemoHms.Data;

namespace DemoHms.Pages.Items
{
    public class IndexModel : PageModel
    {
        private readonly DemoHms.Data.ApplicationDbContext _context;

        public IndexModel(DemoHms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Item> Item { get;set; }

        public async Task OnGetAsync()
        {
            Item = await _context.Items
                .Include(i => i.ItemType).ToListAsync();
            Item = await _context.Items
                .Include(i => i.ItemUnit).ToListAsync();
            Item = await _context.Items
               .Include(i => i.CreatedByUser).ToListAsync();
            Item = await _context.Items
               .Include(i => i.ModifiedByUser).ToListAsync();
        }
    }
}
