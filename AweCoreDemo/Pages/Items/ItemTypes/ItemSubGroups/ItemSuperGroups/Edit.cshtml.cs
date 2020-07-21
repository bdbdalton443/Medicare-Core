using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DemoHms;
using DemoHms.Data;

namespace DemoHms.Pages.Items.ItemTypes.ItemSubGroups.ItemSuperGroups
{
    public class EditModel : PageModel
    {
        private readonly DemoHms.Data.ApplicationDbContext _context;

        public EditModel(DemoHms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ItemSuperType ItemSuperType { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ItemSuperType = await _context.ItemSuperTypes.FirstOrDefaultAsync(m => m.ItemSuperTypeID == id);

            if (ItemSuperType == null)
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

            _context.Attach(ItemSuperType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemSuperTypeExists(ItemSuperType.ItemSuperTypeID))
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

        private bool ItemSuperTypeExists(int id)
        {
            return _context.ItemSuperTypes.Any(e => e.ItemSuperTypeID == id);
        }
    }
}
