using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DemoHms.Data;

namespace AweCoreDemo.Pages.Patients.NextOfKins.NOKRelationships
{
    public class DeleteModel : PageModel
    {
        private readonly DemoHms.Data.ApplicationDbContext _context;

        public DeleteModel(DemoHms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public NOKRelationship NOKRelationship { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            NOKRelationship = await _context.NOKRelationships.FirstOrDefaultAsync(m => m.NOKRelationshipID == id);

            if (NOKRelationship == null)
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

            NOKRelationship = await _context.NOKRelationships.FindAsync(id);

            if (NOKRelationship != null)
            {
                _context.NOKRelationships.Remove(NOKRelationship);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
