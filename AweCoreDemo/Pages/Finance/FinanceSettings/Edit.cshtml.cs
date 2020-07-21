using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DemoHms.Data;

namespace AweCoreDemo.Pages.Finance.FinanceSettings
{
    public class EditModel : PageModel
    {
        private readonly DemoHms.Data.ApplicationDbContext _context;

        public EditModel(DemoHms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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
           ViewData["BillItemTypeID"] = new SelectList(_context.BillItemTypes, "BillItemTypeID", "Name");
           ViewData["HServiceID"] = new SelectList(_context.HServices, "HServiceID", "Name");
           ViewData["ItemID"] = new SelectList(_context.Items, "ItemID", "Name");
           ViewData["TestID"] = new SelectList(_context.Tests, "TestID", "Name");
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
            var item = _context.Items.FirstOrDefault(I => I.ItemID == BillItem.ItemID);
            var service = _context.HServices.FirstOrDefault(I => I.HServiceID == BillItem.HServiceID);
            var test = _context.Tests.FirstOrDefault(I => I.TestID == BillItem.TestID);
            var billItemType = _context.BillItemTypes.FirstOrDefault(B => B.BillItemTypeID == BillItem.BillItemTypeID);
            if (billItemType.Name == "Stock")
            {
                BillItem.HServiceID = null;
                BillItem.HService = null;
                BillItem.TestID = null;
                BillItem.Test = null;
                if (item != null)
                    BillItem.Name = item.Name;
            }
            else if (billItemType.Name == "Service")
            {
                BillItem.TestID = null;
                BillItem.Test = null;
                BillItem.ItemID = null;
                BillItem.Item = null;
                if (service != null)
                    BillItem.Name = service.Name;
            }
            else if (billItemType.Name == "Lab")
            {
                BillItem.HServiceID = null;
                BillItem.HService = null;
                BillItem.ItemID = null;
                BillItem.Item = null;
                if (test != null)
                    BillItem.Name = test.Name;
            }
            _context.Attach(BillItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BillItemExists(BillItem.BillItemID))
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

        private bool BillItemExists(int id)
        {
            return _context.BillItems.Any(e => e.BillItemID == id);
        }
    }
}
