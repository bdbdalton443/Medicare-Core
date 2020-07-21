using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DemoHms.Data;
using Omu.AwesomeMvc;

namespace DemoHms.Pages.Patients.Assignments.Consultations
{
    public class IndexModel : PageModel
    {
        private readonly DemoHms.Data.ApplicationDbContext _context;

        public IndexModel(DemoHms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Assignment> Assignment { get;set; }

        public IList<Bill> Bill { get; set; }
        public Patient Patient { get; set; }
        public ApplicationUser Doctor { get; set; }
        public PatientType PatientType { get; set; }
        public ReferralStatus ReferralStatus { get; set; }
        public static IQueryable<Assignment> AssignmentsCloned { get; set; }
        public async Task OnGetAsync()
        {
            Assignment = await _context.Assignments
                .Include(a => a.Doctor)
                .Include(a => a.Patient)
                .Include(a => a.PatientType)
                .Include(a => a.ReferralStatus).ToListAsync();
            AssignmentsCloned = Assignment.AsQueryable();
        }
        private object MapToGridModel(Assignment o)
        {
            if (o.Patient != null)
                Patient = _context.Patients.FirstOrDefault(I => I.PatientID == o.PatientID);
            if (o.Doctor != null)
                Doctor = _context.AppUsers.FirstOrDefault(I => I.Id == o.DoctorID);
            if (o.PatientType != null)
                PatientType = _context.PatientTypes.FirstOrDefault(I => I.PatientTypeID == o.PatientTypeID);
            if (o.ReferralStatus != null)
                ReferralStatus = _context.ReferralStatuses.FirstOrDefault(I => I.ReferralStatusID == o.ReferralStatusID);
            return new
            {
                o.AssignmentID,
                o.CreatedOn,
                o.UpdatedOn,
                o.Emergency,
                o.Reported,
                o.LastVisted,
                Patient = Patient != null ? Patient.FullName : "",
                Doctor = Doctor != null ? Doctor.FullName : "",
                ReferralStatus = ReferralStatus != null ? ReferralStatus.Name : "",
                PatientType = PatientType != null ? PatientType.Name : "",


                PatientID = o.Patient != null ? o.Patient.PatientID : 0,
                DoctorID = o.Doctor != null ? o.Doctor.Id : "",
                ReferralStatusID = o.ReferralStatus != null ? o.ReferralStatus.ReferralStatusID : 0,
                PatientTypeID = o.PatientType != null ? o.PatientType.PatientTypeID : 0,
            };
        }

        public IActionResult OnPostGridGetItems(GridParams g, string search, string searchStatus)
        {
            IQueryable<Assignment> items = null;
            search = (search ?? "").ToLower();

            if (AssignmentsCloned == null)
                AssignmentsCloned = new List<Assignment>().AsQueryable();
            if (string.IsNullOrWhiteSpace(search) && string.IsNullOrWhiteSpace(search))
            {
                items = AssignmentsCloned;//TestClone.TestConsumables.AsQueryable();
            }
            else
            {
                items = AssignmentsCloned.Where(o => o.Patient != null && (o.Patient.FullName.ToLower().Contains(search) || o.BillStatus.Name.ToLower().Contains(searchStatus))).AsQueryable();
            }

            var model = new GridModelBuilder<Assignment>(items, g)
            {
                Key = "AssignmentID", // needed for api select, update, tree, nesting, EF
                GetItem = () => AssignmentsCloned.FirstOrDefault(T => T.AssignmentID == Convert.ToInt32(g.Key)), // called by the grid.api.update
                Map = MapToGridModel,
            }.Build();

            JsonResult jr = new JsonResult(model);
            return jr;
        }
        public IActionResult OnPostRedirectToExamPage(int ExaminationID)
        {
            RedirectToPage("/Examinations/Edit/" + ExaminationID);
            return new JsonResult(null);
        }

    }
}
