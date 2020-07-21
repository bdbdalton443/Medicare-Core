using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DemoHms.Data;

namespace AweCoreDemo.Pages.Finance.FinanceSettings
{
    public class IndexModel : PageModel
    {
        private readonly DemoHms.Data.ApplicationDbContext _context;

        public IndexModel(DemoHms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<BillItem> BillItem { get;set; }

        public async Task OnGetAsync()
        {
            BillItem = await _context.BillItems
                .Include(b => b.BillItemType)
                .Include(b => b.HService)
                .Include(b => b.Item)
                .Include(b => b.Test).ToListAsync();
        }
    }
}
