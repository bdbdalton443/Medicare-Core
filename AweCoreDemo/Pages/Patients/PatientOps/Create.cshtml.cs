using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DemoHms.Data;

namespace DemoHms.Pages.Patients.PatientOps
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
            ViewData["ServiceCodeID"] = new SelectList(_context.ArmyServices, "ArmyServiceID", "Name");
            ViewData["ArmyStatusID"] = new SelectList(_context.ArmyStatuses, "ArmyStatusID", "Name");
            ViewData["ArmyUnitID"] = new SelectList(_context.ArmyUnits, "ArmyUnitID", "Name");
            ViewData["FamilyID"] = new SelectList(_context.Families, "FamilyID", "Name");
            ViewData["HospitalID"] = new SelectList(_context.Hospitals, "HospitalID", "Name");
            ViewData["NextOfKinID"] = new SelectList(_context.NextOfKins, "NextOfKinID", "FullName");
            ViewData["OrganisationID"] = new SelectList(_context.Organizations, "OrganisationID", "Name");
            ViewData["PatientTypeID"] = new SelectList(_context.PatientTypes, "PatientTypeID", "Name");
            ViewData["RankID"] = new SelectList(_context.Ranks, "RankID", "Name");
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
