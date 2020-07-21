using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AweCoreDemo.Models;
using AweCoreDemo.ViewModels.Input;
using DemoHms;
using DemoHms.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Omu.Awem.Utils;
using Omu.AwesomeMvc;

namespace AweRazorPages.Pages
{
    public class InlineEdtModel2 : PageModel
    {
        public string id = null;
        private readonly DemoHms.Data.ApplicationDbContext _context;
        public InlineEdtModel2(DemoHms.Data.ApplicationDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public Assignment Assignment { get; set; }
        public static Assignment AssignmentClone { get; set; }
        public IList<Treatment> Treatments { get; set; }
        public IList<Examination> Examinations { get; set; }
        public Procedure Procedure { get; set; }
        public IQueryable<Item> Items { get; set; }
        public static IQueryable<Item> Itemz { get; set; }
        public IQueryable<Test> Tests { get; set; }
        public static IQueryable<Test> Testz { get; set; }
        public Examination Examination { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Assignment = await _context.Assignments
                .Include(a => a.Doctor)
                .Include(a => a.Patient)
                .Include(a => a.PatientType)
                .Include(a => a.BillStatus)
                .Include(a => a.ReferralStatus).FirstOrDefaultAsync(m => m.AssignmentID == id);

            AssignmentClone = Assignment;

            if (Assignment == null)
            {
                return NotFound();
            }


            //Treatment Treatment = new Treatment();
            //Treatment.AssignmentID = id;
            //_context.Treatments.Add(Treatment);
            //await _context.SaveChangesAsync();
            Treatments = await _context.Treatments.Where(t => t.AssignmentID == id).ToListAsync();
            Examinations = await _context.Examinations.Include(a=>a.BillStatus).Where(t => t.AssignmentID == id).ToListAsync();
            //foreach (var item in Treatments)
            //{
            //    AssignmentClone.Treatments.Add(item);
            //}
            Itemz = Items = _context.Items.AsQueryable();
            Testz = Tests = _context.Tests.AsQueryable();
            if(Examinations.Where(E=>E.BillStatus.Name.Contains("Pending")).Count()==0)
            {
                var billStatus = _context.BillStatus.FirstOrDefault(B=>B.Name=="Pending Lab");
                Examination = new Examination();
                Examination.BillStatusID = billStatus.BillStatusID;
                Examination.AssignmentID = Assignment.AssignmentID;
                _context.Examinations.Add(Examination);
                _context.SaveChanges();

                Examinations.Add(Examination);
                AssignmentClone.Examinations.Add(Examination);

                Procedure = new Procedure();
                Procedure.ExaminationID = Examination.ExaminationID;
                _context.Procedures.Add(Procedure);
                _context.SaveChanges();

                Examination.Procedures.Add(Procedure);
                AssignmentClone.Examinations.FirstOrDefault(E=>E.ExaminationID==Examination.ExaminationID).Procedures.Add(Procedure);
            }
            ViewData["ReferralStatusID"] = new SelectList(_context.ReferralStatuses, "ReferralStatusID", "Name");
            ViewData["BillStatusID"] = new SelectList(_context.BillStatus, "BillStatusID", "Name");
            ViewData["ItemID"] = new SelectList(_context.Items, "ItemID", "Name");
            return Page();
        }
        public IActionResult OnPostGetCategories()
        {
            var items = Db.Categories
                .Select(o => new KeyContent(o.Id, o.Name));

            return new JsonResult(items);
        }
        public IActionResult OnPostGridGetProcedures(GridParams g, string searchProc)
        {
            IQueryable<Procedure> procedures = null;
            searchProc = (searchProc ?? "").ToLower();
            var procs = new List<Procedure>();
            foreach (var item in AssignmentClone.Examinations)
            {
                if(item.Procedures.Count==0)
                {
                    Procedure = new Procedure();
                    Procedure.ExaminationID = item.ExaminationID;
                    _context.Procedures.Add(Procedure);
                    _context.SaveChanges();

                    item.Procedures.Add(Procedure);
                    AssignmentClone.Examinations.FirstOrDefault(E => E.ExaminationID == item.ExaminationID).Procedures.Add(Procedure);
                }
                foreach (var proc in item.Procedures)
                {
                    procs.Add(proc);
                }
            }
            if (string.IsNullOrWhiteSpace(searchProc))
            {               
                procedures = procs.AsQueryable();
            }
            else
            {
                procedures = procs.Where(o => o.Test != null && o.Test.Name.ToLower().Contains(searchProc)).AsQueryable();
            }

            var model = new GridModelBuilder<Procedure>(procedures, g)
            {
                Key = "ProcedureID", // needed for api select, update, tree, nesting, EF
                GetItem = () => _context.Procedures.FirstOrDefault(T => T.ProcedureID == Convert.ToInt32(g.Key)), // called by the grid.api.update
                Map = MapToGridModel,
            }.Build();

            JsonResult jr = new JsonResult(model);
            return jr;
        }

        private object MapToGridModel(Procedure arg)
        {
            return new
            {
                arg.ProcedureID,
                arg.Description,
                arg.Findings,
                //Date = o.Date.ToShortDateString(),
                //ChefName = o.Chef.FirstName + " " + o.Chef.LastName,
                Tests = string.Join(", ", _context.Tests.Select(m => m.Name)),
                Test = arg.Test != null ? arg.Test.Name : "",
                //o.Organic,
                //DispOrganic = o.Organic ? "Yes" : "No",

                //// below properties used for inline editing only
                // ItemID = Items.Select(m => m.ItemID).ToArray(),
                //ChefId = o.Chef.Id,
                TestID = arg.Test != null ? arg.Test.TestID : 0
            };
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _context.Assignments.Attach(Assignment).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
        public IActionResult OnPostCreate(Procedure input)
        {
            if (ModelState.IsValid)
            {
                var dinner = new Procedure
                {
                    Description = input.Description,
                    Findings = input.Findings,

                    //Chef = Db.Get<Chef>(input.Chef),
                    //Meals = input.Meals.Select(mid => Db.Get<Meal>(mid)),
                    Test = _context.Tests.FirstOrDefault(I => I.TestID == input.TestID)
                    //Organic = input.Organic ?? false
                };

                _context.Procedures.Add(dinner);
                _context.SaveChanges();

                return new JsonResult(new { Item = MapToGridModel(dinner) });
            }

            return new JsonResult(ModelState.GetErrorsInline());
        }

        public IActionResult OnPostEdit(Procedure input)
        {
            if (ModelState.IsValid)
            {
                var dinner = _context.Procedures.FirstOrDefault(T=>T.ProcedureID==input.ProcedureID);
                dinner.Description = input.Description;
                dinner.Findings = input.Findings;

                //Chef = Db.Get<Chef>(input.Chef),
                //Meals = input.Meals.Select(mid => Db.Get<Meal>(mid)),
                dinner.TestID = input.TestID;
                    //Organic = input.Organic ?? false

                _context.Attach(dinner).State = EntityState.Modified;

                _context.SaveChangesAsync();

                return new JsonResult(new { });
            }

            return new JsonResult(ModelState.GetErrorsInline());
        }

        public IActionResult OnGetDelete(int id)
        {
            var dinner = AssignmentClone.Treatments.FirstOrDefault(T=>T.TreatmentID==id);

            return Partial("Delete", new DeleteConfirmInput
            {
                Id = id,
                Type = "dinner",
                Name = dinner.Name
            });
        }

        public IActionResult OnPostDelete(DeleteConfirmInput input)
        {
            Procedure = _context.Procedures.FirstOrDefault(T=>T.ProcedureID==input.Id);

            if (Procedure != null)
            {
                _context.Procedures.Remove(Procedure);
                _context.SaveChangesAsync();
            }

            // the PopupForm's success function utils.itemDeleted expects an obj with "Id" property
            return new JsonResult(new { input.Id });
        }
    }
}