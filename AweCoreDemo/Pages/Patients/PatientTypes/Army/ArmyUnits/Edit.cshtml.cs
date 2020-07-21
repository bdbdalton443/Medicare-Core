using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DemoHms.Data;

namespace DemoHms.Pages.Patients.PatientTypes.Army.ArmyUnits
{
    public class EditModel : PageModel
    {
        private readonly DemoHms.Data.ApplicationDbContext _context;

        public EditModel(DemoHms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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
           ViewData["ArmyDivisionID"] = new SelectList(_context.Set<ArmyDivision>(), "ArmyDivisionID", "ArmyDivisionID");
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

            _context.Attach(ArmyUnit).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArmyUnitExists(ArmyUnit.ArmyUnitID))
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

        private bool ArmyUnitExists(int id)
        {
            return _context.ArmyUnits.Any(e => e.ArmyUnitID == id);
        }
    }
}
