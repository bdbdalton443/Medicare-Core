using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DemoHms.Data;
using Omu.AwesomeMvc;
using DemoHms;

namespace AweCoreDemo.Pages.Lab.Examinations
{
    public class IndexModel : PageModel
    {
        private readonly DemoHms.Data.ApplicationDbContext _context;

        public IndexModel(DemoHms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Examination> Examination { get;set; }
        public IQueryable<Patient> Patients { get; set; }
        public IQueryable<ExaminationStatus> ExaminationStatuses { get; set; }
        public IQueryable<BillStatus> BillStatuses { get; set; }
        public static IList<Examination> Examinations { get; set; }

        public async Task OnGetAsync()
        {
            Examinations=Examination = await _context.Examinations
                .Include(e => e.Assignment)
                .Include(e=>e.Assignment.Patient)
                .Include(e => e.BillStatus)
                .Include(e => e.ExaminationStatus).ToListAsync();
        }
        private object MapToGridModel(Examination o)
        {
            Patients = _context.Patients.AsQueryable();
            ExaminationStatuses = _context.ExaminationStatuses.AsQueryable();
            BillStatuses = _context.BillStatus.AsQueryable();
            Patient item = null;
            ExaminationStatus test = null;
            BillStatus billStatus = null;
            if (o.AssignmentID != null)
                item = _context.Patients.FirstOrDefault(I => I.PatientID == o.Assignment.PatientID);
            if (o.ExaminationStatusID != null)
                test = _context.ExaminationStatuses.FirstOrDefault(I => I.ExaminationStatusID == o.ExaminationStatusID);
            if (o.BillStatusID != null)
                billStatus = _context.BillStatus.FirstOrDefault(I => I.BillStatusID == o.BillStatusID);
            return new
            {
                o.ExaminationID,
                o.Description,
                o.Code,
                Patients = string.Join(", ", Patients.Select(m => m.FullName)),
                ExaminationStatuses = string.Join(", ", ExaminationStatuses.Select(m => m.Name)),
                BillStatuses = string.Join(", ", BillStatuses.Select(m => m.Name)),
                Patient = item != null ? item.FullName : "",
                ExaminationStatus = test != null ? test.Name : "",
                BillStatus = billStatus != null ? billStatus.Name : "",
                //o.Organic,
                //DispOrganic = o.Organic ? "Yes" : "No",

                //// below properties used for inline editing only
                // ItemID = Items.Select(m => m.ItemID).ToArray(),
                //ChefId = o.Chef.Id,
                PatientID = o.Assignment.Patient != null ? o.Assignment.Patient.PatientID : 0,
                ExaminationStatusID = o.ExaminationStatus != null ? o.ExaminationStatus.ExaminationStatusID : 0,
                BillStatusID = o.BillStatus != null ? o.BillStatus.BillStatusID : 0
            };
        }

        public IActionResult OnPostGridGetItems(GridParams g, string search)
        {
            IQueryable<Examination> items = null;
            search = (search ?? "").ToLower();

            if (string.IsNullOrWhiteSpace(search))
            {
                items = Examinations.AsQueryable();//TestClone.TestConsumables.AsQueryable();
            }
            else
            {
                items = Examinations.Where(o => o.Assignment.Patient != null && o.Assignment.Patient.FullName.ToLower().Contains(search)).AsQueryable();
            }

            var model = new GridModelBuilder<Examination>(items, g)
            {
                Key = "ExaminationID", // needed for api select, update, tree, nesting, EF
                GetItem = () => Examinations.FirstOrDefault(T => T.ExaminationID == Convert.ToInt32(g.Key)), // called by the grid.api.update
                Map = MapToGridModel,
            }.Build();

            JsonResult jr = new JsonResult(model);
            return jr;
        }
        public IActionResult OnPostRedirectToExamPage(int ExaminationID)
        {
            RedirectToPage("/Examinations/Edit/"+ExaminationID);
            return new JsonResult(null);
        }
    }
}
