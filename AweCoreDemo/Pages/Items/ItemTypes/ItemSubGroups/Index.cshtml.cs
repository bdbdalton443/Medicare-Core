using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DemoHms;
using DemoHms.Data;

namespace DemoHms.Pages.Items.ItemTypes.ItemSubGroups
{
    public class IndexModel : PageModel
    {
        private readonly DemoHms.Data.ApplicationDbContext _context;

        public IndexModel(DemoHms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<ItemSubGroup> ItemSubGroup { get;set; }

        public async Task OnGetAsync()
        {
            ItemSubGroup = await _context.ItemSubGroups
                .Include(i => i.ItemSuperType).ToListAsync();
        }
    }
}
