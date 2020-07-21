using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DemoHms.Data;

namespace DemoHms.Pages.Patients.Assignments.Consultations
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
        ViewData["DoctorID"] = new SelectList(_context.AppUsers, "Id", "Id");
        ViewData["PatientID"] = new SelectList(_context.Patients, "PatientID", "PatientID");
        ViewData["PatientTypeID"] = new SelectList(_context.PatientTypes, "PatientTypeID", "PatientTypeID");
        ViewData["ReferralStatusID"] = new SelectList(_context.ReferralStatuses, "ReferralStatusID", "ReferralStatusID");
            return Page();
        }

        [BindProperty]
        public Assignment Assignment { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Assignments.Add(Assignment);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
