using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DemoHms.Data;

namespace DemoHms.Pages.Patients.PatientTypes.Army.ArmyUnits
{
    public class DetailsModel : PageModel
    {
        private readonly DemoHms.Data.ApplicationDbContext _context;

        public DetailsModel(DemoHms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public ArmyUnit ArmyUnit { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ArmyUnit = await _context.ArmyUnits
                .Include(a => a.ArmyDivision).FirstOrDefaultAsync(m => m.ArmyUnitID == id);

            if (ArmyUnit == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
