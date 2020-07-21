using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DemoHms;
using DemoHms.Data;

namespace DemoHms.Pages.Items.ItemTypes.ItemSubGroups
{
    public class CreateModel : PageModel
    {
        private readonly DemoHms.Data.ApplicationDbContext _context;

        public CreateModel(DemoHms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["ItemSuperTypeID"] = new SelectList(_context.ItemSuperTypes, "ItemSuperTypeID", "Name");
            return Page();
        }

        [BindProperty]
        public ItemSubGroup ItemSubGroup { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ItemSubGroups.Add(ItemSubGroup);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
