using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AweCoreDemo.Data;
using DemoHms.Data;

namespace AweCoreDemo.Pages.Finance.FinanceSettings.BillItemTypes
{
    public class EditModel : PageModel
    {
        private readonly DemoHms.Data.ApplicationDbContext _context;

        public EditModel(DemoHms.Data.ApplicationDbContext context)
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

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(BillItemType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BillItemTypeExists(BillItemType.BillItemTypeID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool BillItemTypeExists(int id)
        {
            return _context.BillItemTypes.Any(e => e.BillItemTypeID == id);
        }
    }
}
