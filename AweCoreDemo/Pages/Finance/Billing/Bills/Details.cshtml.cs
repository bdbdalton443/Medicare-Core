using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DemoHms;
using DemoHms.Data;

namespace AweCoreDemo.Pages.Finance.Billing.Bills
{
    public class DetailsModel : PageModel
    {
        private readonly DemoHms.Data.ApplicationDbContext _context;

        public DetailsModel(DemoHms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Bill Bill { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Bill = await _context.Bills
                .Include(b => b.BillStatus)
                .Include(b => b.Patient).FirstOrDefaultAsync(m => m.BIllID == id);

            if (Bill == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
