using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DemoHms.Data;
using Microsoft.EntityFrameworkCore;

namespace DemoHms.Pages.EmployeeGroups
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
            return Page();
        }

        [BindProperty]
        public EmployeeGroup EmployeeGroup { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.EmployeeGroups.Add(EmployeeGroup);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                if (ex.InnerException.Message.Contains("Cannot insert duplicate key row in object"))
                    ModelState.AddModelError(string.Empty, "User Role Already Exist");
                return Page();
            }

            return RedirectToPage("./Index");
        }
    }
}
