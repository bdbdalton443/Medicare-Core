using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DemoHms.Data;

namespace DemoHms.Pages.HospitalEntity.Modules.Mappings
{
    public class DeleteModel : PageModel
    {
        private readonly DemoHms.Data.ApplicationDbContext _context;

        public DeleteModel(DemoHms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Mapping Mapping { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Mapping = await _context.Mappings
                .Include(m => m.Hospital)
                .Include(m => m.Module).FirstOrDefaultAsync(m => m.MappingID == id);

            if (Mapping == null)
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

            Mapping = await _context.Mappings.FindAsync(id);

            if (Mapping != null)
            {
                _context.Mappings.Remove(Mapping);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
