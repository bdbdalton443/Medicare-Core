using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AweCoreDemo.Data;
using DemoHms.Data;

namespace AweCoreDemo.Pages.Finance.FinanceSettings.BillItemTypes
{
    public class DeleteModel : PageModel
    {
        private readonly DemoHms.Data.ApplicationDbContext _context;

        public DeleteModel(DemoHms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public BillItemType BillItemType { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            BillItemType = await _context.BillItemTypes.FirstOrDefaultAsync(m => m.BillItemTypeID == id);

            if (BillItemType == null)
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

            BillItemType = await _context.BillItemTypes.FindAsync(id);

            if (BillItemType != null)
            {
                _context.BillItemTypes.Remove(BillItemType);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
