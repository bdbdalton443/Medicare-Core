using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DemoHms.Data;

namespace DemoHms.Pages.Patients.Assignments
{
    public class DetailsModel : PageModel
    {
        private readonly DemoHms.Data.ApplicationDbContext _context;

        public DetailsModel(DemoHms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Patient Patient { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Patient = await _context.Patients
                .Include(p => p.ArmyService)
                .Include(p => p.ArmyStatus)
                .Include(p => p.ArmyUnit)
                .Include(p => p.Family)
                .Include(p => p.Hospital)
                .Include(p => p.NextOfKin)
                .Include(p => p.Organisation)
                .Include(p => p.PatientType)
                .Include(p => p.Rank).FirstOrDefaultAsync(m => m.PatientID == id);

            if (Patient == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
