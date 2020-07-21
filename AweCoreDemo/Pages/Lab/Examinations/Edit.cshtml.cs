using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DemoHms.Data;
using AweCoreDemo.Models;

namespace AweCoreDemo.Pages.Lab.Examinations
{
    public class EditModel : PageModel
    {
        private readonly DemoHms.Data.ApplicationDbContext _context;

        public EditModel(DemoHms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Examination Examination { get; set; }

        public IList<Test> Tests { get; set; }
        public IList<ExaminationStatus> Statuses { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Db.ExaminationID = id;
            Examination = await _context.Examinations
                .Include(e => e.Assignment.Patient)
                .Include(e => e.Assignment)
                .Include(e => e.BillStatus)
                .Include(e => e.ExaminationStatus).FirstOrDefaultAsync(m => m.ExaminationID == id);
            
            Tests = await _context.Tests.ToListAsync();
            Statuses = await _context.ExaminationStatuses.ToListAsync();

            if (Examination == null)
            {
                return NotFound();
            }
            Db.Bill = await _context.Bills.Include(a => a.BillStatus).Include(a => a.Patient).FirstOrDefaultAsync(B => B.PatientID == Examination.Assignment.Patient.PatientID);
            ViewData["AssignmentID"] = new SelectList(_context.Assignments, "AssignmentID", "FullName");
           ViewData["BillStatusID"] = new SelectList(_context.BillStatus, "BillStatusID", "Name");
           ViewData["ExaminationStatusID"] = new SelectList(_context.ExaminationStatuses, "ExaminationStatusID", "Name");
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
            var examination = _context.Examinations.FirstOrDefault(E=>E.ExaminationID==Examination.ExaminationID);
            var pendingTests = _context.Procedures.Include(a => a.ExaminationStatus).Where(P => P.ExaminationID == Examination.ExaminationID && P.ExaminationStatus.Name != "Completed");
            if (pendingTests.Count() == 0)
            {
                examination.ExaminationStatus = _context.ExaminationStatuses.FirstOrDefault(ES => ES.Name == "Completed");
            }
            examination.ExaminationStatusID = Examination.ExaminationStatusID;
            examination.BillStatusID = Examination.BillStatusID;

            _context.Attach(examination).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                Db.Message = "Tests Completed";
                //Db.Message = "<a class=\"dropdown-item d-flex align-items-center\" href=\"#\" id=\"excount\" runat=\"server\" visible=\"false\">" +
                //                                    "<div class=\"mr-3\">" +
                //                                        "<div class=\"icon-circle bg-primary\">" +
                //                                            "<i class=\"fas fa-file-alt text-white\"></i>" +
                //                                        "</div>" +
                //                                    "</div>" +
                //                                    "<div>" +
                //                                        "<div class=\"small text-gray-500\">" +
                //                                            "Examinations:" + "<span class=\"font-weight-bold\" style=\"color:red;\" id=\"lab\" runat=\"server\">" + "Completed Tests" + "</span>" +
                //                                        "</div>" +
                //                                    "</div>" +
                //                               "</a>";
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExaminationExists(Examination.ExaminationID))
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

        private bool ExaminationExists(int id)
        {
            return _context.Examinations.Any(e => e.ExaminationID == id);
        }
    }
}
