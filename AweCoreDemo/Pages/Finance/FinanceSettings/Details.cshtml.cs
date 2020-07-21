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
    public class DetailsModel : PageModel
    {
        private readonly DemoHms.Data.ApplicationDbContext _context;

        public DetailsModel(DemoHms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public BillItem BillItem { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            BillItem = await _context.BillItems
                .Include(b => b.BillItemType)
                .Include(b => b.HService)
                .Include(b => b.Item)
                .Include(b => b.Test).FirstOrDefaultAsync(m => m.BillItemID == id);

            if (BillItem == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
