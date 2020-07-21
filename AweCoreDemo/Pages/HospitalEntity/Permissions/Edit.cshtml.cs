using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DemoHms.Data;

namespace DemoHms.Pages.HospitalEntity.Permissions
{
    public class EditModel : PageModel
    {
        private readonly DemoHms.Data.ApplicationDbContext _context;

        public EditModel(DemoHms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Permission Permission { get; set; }

        private static DateTime? RecDate { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Permission = await _context.Permissions
                .Include(p => p.Activity)
                .Include(p => p.EmployeeGroup).FirstOrDefaultAsync(m => m.PermissionID == id);
            RecDate = Permission.CreatedOn;
            if (Permission == null)
            {
                return NotFound();
            }
           ViewData["ActivityID"] = new SelectList(_context.Activity, "ActivityID", "Name");
           ViewData["EmployeeGroupID"] = new SelectList(_context.EmployeeGroups, "EmployeeGroupID", "Name");
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
            Permission.CreatedOn = RecDate;
            _context.Attach(Permission).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                RecDate = null;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PermissionExists(Permission.PermissionID))
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

        private bool PermissionExists(int id)
        {
            return _context.Permissions.Any(e => e.PermissionID == id);
        }
    }
}
