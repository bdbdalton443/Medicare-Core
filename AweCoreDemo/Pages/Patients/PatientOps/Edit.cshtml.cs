using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DemoHms.Data;

namespace DemoHms.Pages.Patients.PatientOps
{
    public class EditModel : PageModel
    {
        private readonly DemoHms.Data.ApplicationDbContext _context;

        public EditModel(DemoHms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Patient).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PatientExists(Patient.PatientID))
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

        private bool PatientExists(int id)
        {
            return _context.Patients.Any(e => e.PatientID == id);
        }
    }
}
