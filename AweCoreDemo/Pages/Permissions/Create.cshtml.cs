using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DemoHms.Data;

namespace DemoHms.Pages.Permissions
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
            ViewData["ActivityID"] = new SelectList(_context.Activity, "ActivityID", "Name");
            ViewData["EmployeeGroupID"] = new SelectList(_context.EmployeeGroups, "EmployeeGroupID", "Name");
            return Page();
        }

        [BindProperty]
        public Permission Permission { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Permission.Name = Permission.EmployeeGroup.Name + " (" + Permission.Activity.Name + ")";
            _context.Permissions.Add(Permission);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
