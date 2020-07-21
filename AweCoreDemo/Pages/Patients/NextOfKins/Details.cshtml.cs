using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DemoHms.Data;

namespace AweCoreDemo.Pages.Patients.NextOfKins
{
    public class DetailsModel : PageModel
    {
        private readonly DemoHms.Data.ApplicationDbContext _context;

        public DetailsModel(DemoHms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public NextOfKin NextOfKin { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            NextOfKin = await _context.NextOfKins
                .Include(n => n.NOKRelationship).FirstOrDefaultAsync(m => m.NextOfKinID == id);

            if (NextOfKin == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
