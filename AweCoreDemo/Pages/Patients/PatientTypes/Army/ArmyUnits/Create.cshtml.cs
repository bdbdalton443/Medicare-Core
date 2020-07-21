using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DemoHms.Data;

namespace DemoHms.Pages.Patients.PatientTypes.Army.ArmyUnits
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
        ViewData["ArmyDivisionID"] = new SelectList(_context.Set<ArmyDivision>(), "ArmyDivisionID", "ArmyDivisionID");
            return Page();
        }

        [BindProperty]
        public ArmyUnit ArmyUnit { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ArmyUnits.Add(ArmyUnit);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
