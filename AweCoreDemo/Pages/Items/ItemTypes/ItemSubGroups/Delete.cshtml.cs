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
    public class DeleteModel : PageModel
    {
        private readonly DemoHms.Data.ApplicationDbContext _context;

        public DeleteModel(DemoHms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ItemSubGroup ItemSubGroup { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ItemSubGroup = await _context.ItemSubGroups
                .Include(i => i.ItemSuperType).FirstOrDefaultAsync(m => m.ItemSubGroupID == id);

            if (ItemSubGroup == null)
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

            ItemSubGroup = await _context.ItemSubGroups.FindAsync(id);

            if (ItemSubGroup != null)
            {
                _context.ItemSubGroups.Remove(ItemSubGroup);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
