using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DemoHms.Data;
using DemoHms;
using AweCoreDemo.Data;

namespace AweCoreDemo.Pages.Items.Stocks
{
    public class CreateModel : PageModel
    {
        private readonly DemoHms.Data.ApplicationDbContext _context;
        public IQueryable<Item> items { get; set; }
        public IQueryable<Department> departments { get; set; }
        public CreateModel(DemoHms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            items = _context.Items.AsQueryable();
            departments = _context.Departments.AsQueryable();

        ViewData["DepartmentID"] = new SelectList(_context.Departments, "DepartmentID", "Name");
        ViewData["ItemID"] = new SelectList(_context.Items, "ItemID", "Name");
            return Page();
        }

        [BindProperty]
        public Stok Stock { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Stoks.Add(Stock);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
