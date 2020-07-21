using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DemoHms.Data;
using AweCoreDemo.Models;

namespace AweCoreDemo.Pages.Dispensory
{
    public class DetailsModel : PageModel
    {
        private readonly DemoHms.Data.ApplicationDbContext _context;

        public DetailsModel(DemoHms.Data.ApplicationDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public Assignment Assignment { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Db.Assignment = Assignment = await _context.Assignments
                .Include(a => a.BillStatus)
                .Include(a => a.Doctor)
                .Include(a => a.Patient)
                .Include(a => a.PatientType)
                .Include(a => a.ReferralStatus).Include(a=>a.Treatments).FirstOrDefaultAsync(m => m.AssignmentID == id);

            if (Assignment == null)
            {
                return NotFound();
            }
            return Page();
        }
        
    }
}
