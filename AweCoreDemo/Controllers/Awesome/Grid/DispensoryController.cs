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

namespace AweCoreDemo.Controllers.Awesome.Grid
{
    public class DispensoryController : Controller
    {
        private ApplicationDbContext _context { get; }
        private IQueryable<Item> Items { get; set; }

        public DispensoryController(ApplicationDbContext context)
        {
            _context = context;
        }
        private object MapToGridModel(Treatment o)
        {
           
            Items = _context.Items.AsQueryable();
            Item item = null;
            if (o.ItemID != null)
                item = _context.Items.FirstOrDefault(I => I.ItemID == o.ItemID);
           
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
                o.DispensedQty,
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
        public IActionResult GridGetItems(GridParams g, string search)
        {

            IQueryable<Treatment> items = null;
            search = (search ?? "").ToLower();
            if (string.IsNullOrWhiteSpace(search))
            {
                items = Db.Assignment.Treatments.AsQueryable();

            }
            else
            {
                items = Db.Assignment.Treatments.Where(o => o.Item != null && o.Item.Name.ToLower().Contains(search)).AsQueryable();
            }

            var model = new GridModelBuilder<Treatment>(items, g)
            {
                Key = "TreatmentID", // needed for api select, update, tree, nesting, EF
                GetItem = () => Db.Assignment.Treatments.FirstOrDefault(T => T.TreatmentID == Convert.ToInt32(g.Key)), // called by the grid.api.update
                Map = MapToGridModel,
            }.Build();

            JsonResult jr = new JsonResult(model);
            return jr;
        }
        public IActionResult Create(Treatment input)
        {           
            return new JsonResult(new { Item = MapToGridModel(input) });        
        }
        public IActionResult Edit(Treatment input)
        {
            if (ModelState.IsValid)
            {
                var item = _context.Items.FirstOrDefault(I => I.ItemID == input.ItemID);
              
                var dinner = Db.Assignment.Treatments.FirstOrDefault(T => T.TreatmentID == input.TreatmentID);
                dinner.PreQuantity = input.PreQuantity;
                dinner.PostQuantity = input.PostQuantity;
                dinner.AdjustedAmount = input.AdjustedAmount;
                dinner.Total = input.Total;
                dinner.OriginalAmount = input.OriginalAmount;
                dinner.AdjustedAmount = input.AdjustedAmount;
                dinner.DispensedQty = input.DispensedQty;
                dinner.Balance = input.AdjustedAmount - input.DispensedQty;
                if(dinner.Balance==0)
                {
                    dinner.DispenseStatusID = _context.DispenseStatuses.FirstOrDefault(D=>D.Name=="Dispense Completed").DispenseStatusID;
                }

                _context.Attach(dinner).State = EntityState.Modified;

                _context.SaveChanges();

                if(dinner.DispensedQty != 0)
                {
                    DispenseRoutine dr = new DispenseRoutine();
                    dr.ItemID = item.ItemID;
                    dr.TreatmentID = dinner.TreatmentID;
                    dr.PatientID = dinner.Assignment.PatientID;
                    dr.Quantity = dinner.DispensedQty;
                    dr.Total = dinner.AdjustedAmount;
                    _context.DispenseRoutines.Add(dr);
                    _context.SaveChanges();

                    var user = _context.AppUsers.FirstOrDefault(U=>U.Email==User.Identity.Name);
                    var department = _context.Departments.FirstOrDefault(D => D.DepartmentID == user.DepartmentID);
                    
                    Stok stok = _context.Stoks.Include(a=>a.Item).Include(a=>a.Department).FirstOrDefault(S=>S.Item.ItemID==dr.ItemID && S.Department.DepartmentID==department.DepartmentID);
                    stok.Quantity = stok.Quantity - dr.Quantity;
                    _context.Stoks.Attach(stok).State = EntityState.Modified;
                    _context.SaveChanges();

                    StockRoutine sr = new StockRoutine();
                    sr.StockID = stok.StockID;
                    sr.RoutineTypeID = _context.RoutineType.FirstOrDefault(R=>R.Name=="Dispense").RoutineTypeID;
                    sr.Quantity = dr.Quantity;
                    sr.ItemID = dr.ItemID;
                    sr.TreatmentID = dinner.TreatmentID;

                    _context.StockRoutines.Add(sr);
                    _context.SaveChanges();
                }

                return new JsonResult(new { });
            }

            return new JsonResult(ModelState.GetErrorsInline());
        }
        public IActionResult Delete(DeleteConfirmInput input)
        {
            var Treatment = Db.Assignment.Treatments.FirstOrDefault(T => T.TreatmentID == input.Id);

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