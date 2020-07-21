using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AweCoreDemo.Hubs;
using AweCoreDemo.Models;
using AweCoreDemo.ViewModels.Input;
using DemoHms;
using DemoHms.Data;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Omu.Awem.Utils;
using Omu.AwesomeMvc;


namespace AweRazorPages.Pages
{
    public class InlineEdtModel : PageModel
    {
        private readonly DemoHms.Data.ApplicationDbContext _context;
        //private IHubContext<SyncHub> _hubcontext;
        //private IHubContext<SyncHub> _hubcontext1;
        public InlineEdtModel(DemoHms.Data.ApplicationDbContext context)
        {
            _context = context;
          
        }
        [BindProperty]
        public Assignment Assignment { get; set; }
        public static Assignment AssignmentCloned { get; set; }
        public IList<Treatment> Treatments { get; set; }
        public IList<Examination> Examinations { get; set; }
        public Treatment Treatment { get; set; }
        public IQueryable<Item> Items { get; set; }
        public static IQueryable<Item> Itemz { get; set; }
        public IQueryable<Test> Tests { get; set; }
        public static IQueryable<Test> Testz { get; set; }
        public string Grd { get; set; }
        private static Bill Bill { get; set; }

        public string BillStatus { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
           // _hubcontext1 = _hubcontext;
            Db.FirstLoad = true;
            if (id == null)
            {
                return NotFound();
            }
            Grd = "treatments";
            Assignment = Db.Assignment = await _context.Assignments
                .Include(a => a.Doctor)
                .Include(a => a.Patient)
                .Include(a => a.PatientType)
                .Include(a => a.BillStatus)
                .Include(a => a.ReferralStatus).FirstOrDefaultAsync(m => m.AssignmentID == id);

            AssignmentCloned = Assignment;

            if (Assignment == null)
            {
                return NotFound();
            }

            Treatments = await _context.Treatments.Where(t => t.AssignmentID == id).ToListAsync();
            Examinations = await _context.Examinations.Where(t => t.AssignmentID == id).ToListAsync();

            Db.Bill = Bill = await _context.Bills.Include(a => a.BillStatus).Include(a => a.Patient).FirstOrDefaultAsync(B => B.PatientID == Assignment.PatientID);

            if(Bill != null)
                Bill.Total = Db.Total = _context.Receipts.Where(RC =>RC.BillID == Bill.BIllID).Sum(R => R.AdjustedCost);
            if(Bill != null)
            {
                if (Bill.BillStatus != null)
                    BillStatus = Bill.BillStatus.Name;
                else
                    BillStatus = "Pending Dispense";
            }
            else
            {
                BillStatus = "Pending Dispense";
            }

            if (Db.Total == null) Db.Total = 0;

            var blID = _context.BillStatus.FirstOrDefault(B => B.Name == "Pending Lab").BillStatusID;

            if (Examinations.Where(B => B.BillStatusID == blID).Count()==0)
            {
                Examination examination = new Examination();
                examination.AssignmentID = Assignment.AssignmentID;
                examination.BillStatusID = blID;
                _context.Examinations.Add(examination);
                _context.SaveChanges();
                Examinations.Add(examination);
               Db.Assignment.Examinations.Add(examination);
            }
            else
            {
                foreach (var item in Examinations.Where(B => B.BillStatusID == blID))
                {
                    Db.Assignment.Examinations.Add(item);
                }
            }
            Itemz = Items = _context.Items.AsQueryable();
            Testz = Tests = _context.Tests.AsQueryable();
            Db.BillStatusID = blID;
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

        private object MapToGridModel(Treatment o)
        {
            int? itemPrice = 0;
            Items = _context.Items.AsQueryable();
            Item item = null;
            if (o.ItemID != null)
                item = _context.Items.FirstOrDefault(I => I.ItemID == o.ItemID);
            var bi = _context.BillItems.FirstOrDefault(I => I.ItemID == item.ItemID);
            if(bi != null)
                itemPrice = bi.Cost;
            //o.Total = GetOriginalAmount(o);
            return new
            {
                o.TreatmentID,
                o.PreQuantity,
                o.PostQuantity,
                o.OriginalAmount,
                o.AdjustedAmount,
                o.Total,
                o.X,
                o.Days,
                //Date = o.Date.ToShortDateString(),
                //ChefName = o.Chef.FirstName + " " + o.Chef.LastName,
                Items = string.Join(", ", Items.Select(m => m.ExtendedName)),
                Item = item != null ? item.ExtendedName : "",
                //o.Organic,
                //DispOrganic = o.Organic ? "Yes" : "No",

                //// below properties used for inline editing only
                // ItemID = Items.Select(m => m.ItemID).ToArray(),
                //ChefId = o.Chef.Id,
                ItemID = o.Item != null ? o.Item.ItemID : 0
            };           
        }

        public IActionResult OnPostGridGetItems(GridParams g, string search)
        {
            IQueryable<Treatment> items = null;
            search = (search ?? "").ToLower();
            if(string.IsNullOrWhiteSpace(search))
            {
                items = AssignmentCloned.Treatments.AsQueryable();
                
            }
            else
            {
                items = AssignmentCloned.Treatments.Where(o => o.Item != null && o.Item.Name.ToLower().Contains(search)).AsQueryable();
            }

            var model = new GridModelBuilder<Treatment>(items, g)
            {
                Key = "TreatmentID", // needed for api select, update, tree, nesting, EF
                GetItem = () => AssignmentCloned.Treatments.FirstOrDefault(T => T.TreatmentID == Convert.ToInt32(g.Key)), // called by the grid.api.update
                Map = MapToGridModel,
            }.Build();

            JsonResult jr = new JsonResult(model);
            return jr;
        }
        public async Task<IActionResult> OnPostAsync()
        {
            var assignment = await _context.Assignments.FirstOrDefaultAsync(A=>A.AssignmentID==Assignment.AssignmentID);
            if (!ModelState.IsValid)
            {
                return Page();
            }
            assignment.BillStatusID = Assignment.BillStatusID;
            assignment.Description = Assignment.Description;
            assignment.Recommendation = Assignment.Recommendation;
            assignment.ReferralStatusID = Assignment.ReferralStatusID;
            _context.Assignments.Attach(assignment).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            var entries = _context.ChangeTracker.Entries().ToList();
            var entt = entries.FirstOrDefault();
            _context.Entry(entt.Entity).State = EntityState.Detached;
            // _context.ChangeTracker.AutoDetectChangesEnabled = false;

            if (Bill == null)
            {
                Bill = new Bill();
                Bill.PatientID = AssignmentCloned.PatientID;
                Bill.BillStatusID = Assignment.BillStatusID;

                _context.Bills.Add(Bill);
                _context.SaveChanges();
            }

            Bill.BillStatusID = Assignment.BillStatusID;
            
            _context.Bills.Attach(Bill).State = EntityState.Modified;

            await _context.SaveChangesAsync();
            //_context.ChangeTracker.AutoDetectChangesEnabled = true;

            //var user = await _context.AppUsers.Include(E => E.EmployeeGroup).FirstOrDefaultAsync(U => U.Email == User.Identity.Name);
            //await _hubcontext.Clients.All.Send(User.Identity.Name, "BroadCast", user.EmployeeGroup.Name);

            return RedirectToPage("./Index");
        }
        public IActionResult OnPostCreate(Treatment input)
        {
            Receipt receipt = null;
            int itemPrice = 0;
            if (Bill == null)
            {
                Bill = new Bill();
                Bill.PatientID = AssignmentCloned.PatientID;
                Bill.BillStatusID = Assignment.BillStatusID;

                _context.Bills.Add(Bill);
                _context.SaveChanges();
            }
            if (ModelState.IsValid)
            {
                var item = _context.Items.FirstOrDefault(I => I.ItemID == input.ItemID);
                var bi = _context.BillItems.FirstOrDefault(I => I.ItemID == item.ItemID);
                if (bi != null)
                    itemPrice = bi.Cost;
                var dinner = new Treatment
                {
                    PreQuantity = input.PreQuantity,
                    PostQuantity = input.PostQuantity,
                    AssignmentID = AssignmentCloned.AssignmentID,
                    OriginalAmount = GetOriginalAmount(input),
                    AdjustedAmount = input.AdjustedAmount == 0 || input.AdjustedAmount == null ? GetOriginalAmount(input) : input.AdjustedAmount,
                    ItemID = item.ItemID,
                    Item = item,
                    Days = input.Days,
                    Total = input.Total,
                    Balance = input.AdjustedAmount == 0 || input.AdjustedAmount == null ? GetOriginalAmount(input) : input.AdjustedAmount

                    //Organic = input.Organic ?? false
                };
                _context.Treatments.Add(dinner);
                _context.SaveChanges();

                receipt = _context.Receipts.FirstOrDefault(R => R.TreatmentID == dinner.TreatmentID);

                if (receipt == null)
                {
                    receipt = new Receipt();
                    receipt.BillID = Bill.BIllID;
                    receipt.TreatmentID = dinner.TreatmentID;
                    _context.Receipts.Add(receipt);
                    _context.SaveChanges();
                }

                receipt.AdjustedAmount = dinner.AdjustedAmount;
                receipt.Cost = itemPrice;
                receipt.AdjustedCost = itemPrice * dinner.AdjustedAmount;
                receipt.Amount = dinner.OriginalAmount;

                dinner.BIllID = Bill.BIllID;
                _context.Treatments.Attach(dinner).State = EntityState.Modified;
                _context.Receipts.Attach(receipt).State = EntityState.Modified;

                _context.SaveChanges();

                Bill.Total = dinner.Total = Db.Total = _context.Receipts.Where(RC => RC.BillID == Bill.BIllID).Sum(R => R.AdjustedCost);
                var rrs = _context.ReceiptRoutines.Where(RR => RR.BillID == Bill.BIllID);
                if (rrs.Count() > 0)
                {
                    Bill.Balance = Bill.Total - rrs.Sum(RC => RC.Amount);
                }
                else
                {
                    Bill.Balance = Bill.Total;
                }
                _context.Bills.Attach(Bill).State = EntityState.Modified;

                _context.SaveChanges();

                //_hubcontext.Clients.All.SendSelfMessage("", Db.Total.ToString());

                return new JsonResult(new { Item = MapToGridModel(dinner) });
            }

            return new JsonResult(ModelState.GetErrorsInline());
        }

        private int? GetOriginalAmount(Treatment input)
        {

           if(input.PreQuantity != 0 && input.PostQuantity != 0 && input.Days != 0)
            {
                return input.PreQuantity * input.PostQuantity * input.Days;
            }
            else
            {
                return 0;
            }
        }

        public IActionResult OnPostEdit(Treatment input)
        {
            Receipt receipt = null;
            int itemPrice = 0;
            if (ModelState.IsValid)
            {
                var item = _context.Items.FirstOrDefault(I => I.ItemID == input.ItemID);
                var bi = _context.BillItems.FirstOrDefault(I => I.ItemID == item.ItemID);
                if (bi != null)
                    itemPrice = bi.Cost;
                var dinner = AssignmentCloned.Treatments.FirstOrDefault(T=>T.TreatmentID==input.TreatmentID);
                dinner.PreQuantity = input.PreQuantity;
                dinner.PostQuantity = input.PostQuantity;
                dinner.ItemID = input.ItemID;
                dinner.AdjustedAmount = input.AdjustedAmount;
                dinner.Total = input.Total;
                dinner.OriginalAmount = GetOriginalAmount(input);

                if (dinner.AdjustedAmount == 0 || dinner.AdjustedAmount == null)
                    dinner.AdjustedAmount = input.OriginalAmount;

                if (Bill == null)
                {
                    Bill = new Bill();
                    Bill.PatientID = AssignmentCloned.PatientID;
                    Bill.BillStatusID = Assignment.BillStatusID;

                    _context.Bills.Add(Bill);
                    _context.SaveChanges();
                }

                receipt = _context.Receipts.FirstOrDefault(R=>R.TreatmentID==dinner.TreatmentID);

                if(receipt==null)
                {
                    receipt = new Receipt();
                    receipt.BillID = Bill.BIllID;
                    receipt.Bill = Bill;
                    _context.Receipts.Add(receipt);
                    _context.SaveChanges();
                }

                receipt.AdjustedAmount = dinner.AdjustedAmount;
                receipt.Cost = itemPrice;
                receipt.Amount = dinner.OriginalAmount;
                receipt.AdjustedCost = itemPrice * dinner.AdjustedAmount;

                _context.Attach(receipt).State=EntityState.Modified;
                _context.Attach(dinner).State = EntityState.Modified;

                _context.SaveChanges();

                Bill.Total = Db.Total=_context.Receipts.Where(RC=>RC.BillID==Bill.BIllID).Sum(R=>R.AdjustedCost);
                var rrs = _context.ReceiptRoutines.Where(RR => RR.BillID == Bill.BIllID);
                if (rrs.Count()>0)
                {
                    Bill.Balance = Bill.Total - rrs.Sum(RC => RC.Amount);
                }
                else
                {
                    Bill.Balance = Bill.Total;
                }
                
                _context.Attach(Bill).State = EntityState.Modified;

                _context.SaveChanges();

                return new JsonResult(new { });
            }

            return new JsonResult(ModelState.GetErrorsInline());
        }

        public IActionResult OnGetDelete(int id)
        {
            var dinner = AssignmentCloned.Treatments.FirstOrDefault(T=>T.TreatmentID==id);

            return Partial("Delete", new DeleteConfirmInput
            {
                Id = id,
                Type = "dinner",
                Name = dinner.Name
            });
        }

        public IActionResult OnPostDelete(DeleteConfirmInput input)
        {
            Treatment = AssignmentCloned.Treatments.FirstOrDefault(T=>T.TreatmentID==input.Id);

            if (Treatment != null)
            {
                _context.Treatments.Remove(Treatment);
                _context.SaveChangesAsync();
            }

            // the PopupForm's success function utils.itemDeleted expects an obj with "Id" property
            return new JsonResult(new { input.Id });
        }
    }
}