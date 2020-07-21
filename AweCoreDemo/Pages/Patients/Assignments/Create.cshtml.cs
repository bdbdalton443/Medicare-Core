using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DemoHms.Data;

namespace DemoHms.Pages.Patients.Assignments
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
            ViewData["ServiceCodeID"] = new SelectList(_context.ArmyServices, "ArmyServiceID", "ArmyServiceID");
            ViewData["ArmyStatusID"] = new SelectList(_context.ArmyStatuses, "ArmyStatusID", "ArmyStatusID");
            ViewData["ArmyUnitID"] = new SelectList(_context.ArmyUnits, "ArmyUnitID", "ArmyUnitID");
            ViewData["FamilyID"] = new SelectList(_context.Families, "FamilyID", "FamilyID");
            ViewData["HospitalID"] = new SelectList(_context.Hospitals, "HospitalID", "HospitalID");
            ViewData["NextOfKinID"] = new SelectList(_context.NextOfKins, "NextOfKinID", "NextOfKinID");
            ViewData["OrganisationID"] = new SelectList(_context.Organizations, "OrganisationID", "OrganisationID");
            ViewData["PatientTypeID"] = new SelectList(_context.PatientTypes, "PatientTypeID", "PatientTypeID");
            ViewData["RankID"] = new SelectList(_context.Ranks, "RankID", "RankID");
            return Page();
        }

        [BindProperty]
        public Patient Patient { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Patients.Add(Patient);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
