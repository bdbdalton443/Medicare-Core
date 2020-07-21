using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DemoHms.Data;

namespace DemoHms.Pages.Patients.PatientTypes.Army.ArmyStatuses
{
    public class DetailsModel : PageModel
    {
        private readonly DemoHms.Data.ApplicationDbContext _context;

        public DetailsModel(DemoHms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public ArmyStatus ArmyStatus { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ArmyStatus = await _context.ArmyStatuses.FirstOrDefaultAsync(m => m.ArmyStatusID == id);

            if (ArmyStatus == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
