using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AweCoreDemo.Data;
using AweCoreDemo.Models;
using AweCoreDemo.ViewModels.Input;
using DemoHms;
using DemoHms.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Omu.Awem.Utils;
using Omu.AwesomeMvc;

namespace AweCoreDemo.Controllers.Demos.Grid
{
    public class ProceduresController : Controller
    {
        private readonly DemoHms.Data.ApplicationDbContext _context;
        private static Bill Bill { get; set; }
        private static Receipt receipt { get; set; }
        public ProceduresController(DemoHms.Data.ApplicationDbContext context)
        {
            _context = context;
        }
        private object MapToGridModel(Procedure arg)
        {
            return new
            {
                arg.ProcedureID,
                arg.Description,
                arg.Findings,
                arg.AdjustedAmount,
                arg.OriginalAmount,
                Tests = string.Join(", ", _context.Tests.Select(m => m.Name)),
                Test = arg.Test != null ? arg.Test.Name : "",
                TestID = arg.Test != null ? arg.Test.TestID : 0,
                ExaminationStatuses = string.Join(", ", _context.ExaminationStatuses.Select(e => e.Name)),
                ExaminationStatus = arg.ExaminationStatus != null ? arg.ExaminationStatus.Name : "",
                ExaminationStatusID = arg.ExaminationStatus != null ? arg.ExaminationStatus.ExaminationStatusID : 0,
            };
        }
        public IActionResult GridGetItems(GridParams g, string search)
        {
            search = (search ?? "").ToLower();
            var procedures = _context.Procedures.Include(t => t.Test).Include(t => t.ExaminationStatus).Where(o => o.Test.Name.ToLower().Contains(search)).AsQueryable();

            if (Db.ExaminationID != null)
                procedures = procedures.Where(P=>P.ExaminationID==Db.ExaminationID);

            var model = new GridModelBuilder<Procedure>(procedures, g)
            {
                Key = "ProcedureID", // needed for api select, update, tree, nesting, EF
                GetItem = () => _context.Procedures.Include(e=>e.ExaminationStatus).FirstOrDefault(p => p.ProcedureID == Convert.ToInt32(g.Key)), // called by the grid.api.update
                Map = MapToGridModel,
            }.Build();

            return Json(model);
        }
        [HttpPost]
        public IActionResult Create(Procedure input)
        {
            if (Db.Bill == null)
            {
                Bill = new Bill();
                Bill.PatientID = Db.Assignment.PatientID;
                Bill.BillStatusID = Db.Assignment.BillStatusID;

                _context.Bills.Add(Bill);
                _context.SaveChanges();
                Db.Bill = Bill;
            }
            else
            {
                Bill = Db.Bill;
            }
            int itemPrice = 0;
            if (ModelState.IsValid)
            {
                var item = _context.Tests.FirstOrDefault(I => I.TestID == input.TestID);
                var bi = _context.BillItems.FirstOrDefault(I => I.TestID == item.TestID);
                if (bi != null)
                    itemPrice = bi.Cost;
                var dinner = new Procedure
                {
                    Description = input.Description,
                    Findings = input.Findings,
                    ExaminationID = Db.Examination.ExaminationID,
                    OriginalAmount = input.OriginalAmount,
                    AdjustedAmount = input.AdjustedAmount == 0 || input.AdjustedAmount == null ? input.OriginalAmount : input.AdjustedAmount,
                    //Chef = Db.Get<Chef>(input.Chef),
                    //Meals = input.Meals.Select(mid => Db.Get<Meal>(mid)),
                    Test = _context.Tests.FirstOrDefault(I => I.TestID == input.TestID),
                    TestID = input.TestID!=null?input.TestID:null,
                    ExaminationStatus = _context.ExaminationStatuses.FirstOrDefault(I => I.ExaminationStatusID == input.ExaminationStatusID),
                    ExaminationStatusID = input.ExaminationStatusID != null ? input.ExaminationStatusID : null
                    //Organic = input.Organic ?? false
                };

                _context.Procedures.Add(dinner);
                _context.SaveChanges();

                receipt = _context.Receipts.FirstOrDefault(R => R.ProcedureID == dinner.ProcedureID);

                if (receipt == null)
                {
                    receipt = new Receipt();
                    receipt.BillID = Bill.BIllID;
                    receipt.ProcedureID = dinner.ProcedureID;
                    _context.Receipts.Add(receipt);
                    _context.SaveChanges();
                }

                receipt.AdjustedAmount = dinner.AdjustedAmount;
                receipt.Cost = itemPrice;
                receipt.AdjustedCost = itemPrice * dinner.AdjustedAmount;
                receipt.Amount = dinner.OriginalAmount;

                dinner.BillID = Bill.BIllID;
                _context.Procedures.Attach(dinner).State = EntityState.Modified;
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
                _context.Attach(Bill).State = EntityState.Modified;

                _context.SaveChanges();

                Db.Bill = Bill;

                return new JsonResult(new { Item = MapToGridModel(dinner) });
            }

            return new JsonResult(ModelState.GetErrorsInline());
        }
        [HttpPost]
        public IActionResult Edit(Procedure input)
        {
            if (Db.Bill == null && !Db.IsLab)
            {
                Bill = new Bill();
                Bill.PatientID = Db.Assignment.PatientID;
                Bill.BillStatusID = Db.Assignment.BillStatusID;

                _context.Bills.Add(Bill);
                _context.SaveChanges();
                Db.Bill = Bill;
            }
            else
            {
                Bill = Db.Bill;
            }
            int itemPrice = 0;
            if (ModelState.IsValid)
            {
                var dinner = _context.Procedures.Include(t=>t.Test).Include(e => e.ExaminationStatus).FirstOrDefault(T => T.ProcedureID == input.ProcedureID);
                var item = _context.Tests.Include(a=>a.TestConsumables).FirstOrDefault(I => I.TestID == input.TestID);
                var bi = _context.BillItems.FirstOrDefault(I => I.TestID == item.TestID);
                var exStatus = _context.ExaminationStatuses.FirstOrDefault(E=>E.ExaminationStatusID==input.ExaminationStatusID);
                if (bi != null)
                    itemPrice = bi.Cost;
                if (!Db.IsLab)
                {
                    dinner.Description = input.Description;

                    dinner.TestID = input.TestID;

                    dinner.Test = item;

                    dinner.AdjustedAmount = input.AdjustedAmount;

                    receipt = _context.Receipts.FirstOrDefault(R => R.ProcedureID == dinner.ProcedureID);

                    if (receipt == null)
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

                    _context.Attach(receipt).State = EntityState.Modified;
                }
                else 
                {
                    dinner.Findings = input.Findings;
                    dinner.ExaminationStatusID = input.ExaminationStatusID;
                    dinner.ExaminationStatus = exStatus;
                }
                
                //Organic = input.Organic ?? false

                
                _context.Attach(dinner).State = EntityState.Modified;

                _context.SaveChanges();

                if (!Db.IsLab)
                {
                    Bill.Total = Db.Total = _context.Receipts.Where(RC => RC.BillID == Bill.BIllID).Sum(R => R.AdjustedCost);
                    var rrs = _context.ReceiptRoutines.Where(RR => RR.BillID == Bill.BIllID);
                    if (rrs.Count() > 0)
                    {
                        Bill.Balance = Bill.Total - rrs.Sum(RC => RC.Amount);
                    }
                    else
                    {
                        Bill.Balance = Bill.Total;
                    }
                    _context.DetachAllEntities();
                    _context.Bills.Attach(Bill).State = EntityState.Modified;

                    _context.SaveChanges();

                    Db.Bill = Bill;
                }
                else
                {
                    var user = _context.AppUsers.FirstOrDefault(U => U.Email == User.Identity.Name);
                    var department = _context.Departments.FirstOrDefault(D => D.DepartmentID == user.DepartmentID);
                    //Update Stock Count
                    foreach (TestConsumable tc in item.TestConsumables)
                    {
                        var st = _context.Stoks.Include(a => a.Item).Include(a => a.Department).FirstOrDefault(S => S.Item.ItemID == tc.ItemID && S.Department.DepartmentID == department.DepartmentID);
                        st.Quantity = st.Quantity - tc.Quantity;
                        _context.Stoks.Attach(st).State = EntityState.Modified;
                        _context.SaveChanges();

                        StockRoutine sr = new StockRoutine();
                        sr.StockID = st.StockID;
                        sr.RoutineTypeID = _context.RoutineType.FirstOrDefault(R => R.Name == "Lab Consumable").RoutineTypeID;
                        sr.Quantity = tc.Quantity;
                        sr.ItemID = tc.ItemID;
                        sr.ProcedureID = dinner.ProcedureID;
                        sr.TestConsumableID = tc.TestConsumableID;

                        _context.StockRoutines.Add(sr);
                        _context.SaveChanges();
                    }
                   
                }
                
                return new JsonResult(new { });
            }

            return new JsonResult(ModelState.GetErrorsInline());
        }
        public IActionResult Delete(int ProcedureID)
        {
            var dinner = _context.Procedures.Include(t => t.Test).FirstOrDefault(p => p.ProcedureID == ProcedureID);

            return PartialView("Delete", new DeleteConfirmInput
            {
                Id = ProcedureID,
                Type = "procedure",
                Name = dinner.ProcedureID.ToString()
            });
        }
        [HttpPost]
        public IActionResult Delete(DeleteConfirmInput input)
        {
            _context.Procedures.Remove(_context.Procedures.FirstOrDefault(p => p.ProcedureID == input.Id));
            _context.SaveChanges();

            // the PopupForm's success function utils.itemDeleted expects an obj with "Id" property
            return Json(new { input.Id });
        }
    }
}