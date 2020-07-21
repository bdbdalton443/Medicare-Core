using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DemoHms;
using DemoHms.Data;
using Omu.AwesomeMvc;

namespace AweCoreDemo.Pages.Finance.Billing.Bills
{
    public class IndexModel : PageModel
    {
        private readonly DemoHms.Data.ApplicationDbContext _context;

        public IndexModel(DemoHms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Bill> Bill { get;set; }
        public Patient Patient { get; set; }
        public BillStatus BillStatus { get; set; }
        public static IQueryable<Bill> BillsCloned { get; set; }
        public async Task OnGetAsync()
        {
            Bill = await _context.Bills
                .Include(b => b.BillStatus)
                .Include(b => b.Patient).ToListAsync();
            BillsCloned = Bill.AsQueryable();
        }
        private object MapToGridModel(Bill o)
        {
            if (o.Patient != null)
                Patient = _context.Patients.FirstOrDefault(I => I.PatientID == o.PatientID);
            if (o.BillStatusID != null)
                BillStatus = _context.BillStatus.FirstOrDefault(I => I.BillStatusID == o.BillStatusID);
            return new
            {
                o.BIllID,
                o.Balance,
                o.FinalPrint,
                o.InitialPrint,
                o.Total,
                Patient = Patient != null ? Patient.FullName : "",  
                BillStatus = BillStatus != null ? BillStatus.Name : "",

                PatientID = o.Patient != null ? o.Patient.PatientID : 0,
                BillStatusID = o.BillStatus != null ? o.BillStatus.BillStatusID : 0
            };
        }

        public IActionResult OnPostGridGetItems(GridParams g, string search, string searchStatus)
        {
            IQueryable<Bill> items = null;
            search = (search ?? "").ToLower();

            if (BillsCloned == null)
                BillsCloned = new List<Bill>().AsQueryable();
            if (string.IsNullOrWhiteSpace(search) && string.IsNullOrWhiteSpace(search))
            {
                items = BillsCloned;//TestClone.TestConsumables.AsQueryable();
            }
            else
            {
                items = BillsCloned.Where(o => o.Patient != null && (o.Patient.FullName.ToLower().Contains(search) || o.BillStatus.Name.ToLower().Contains(searchStatus))).AsQueryable();
            }

            var model = new GridModelBuilder<Bill>(items, g)
            {
                Key = "BIllID", // needed for api select, update, tree, nesting, EF
                GetItem = () => BillsCloned.FirstOrDefault(T => T.BIllID == Convert.ToInt32(g.Key)), // called by the grid.api.update
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
