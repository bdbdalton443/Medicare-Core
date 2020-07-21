using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AweCoreDemo.Data;
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
    public class NewStockController : Controller
    {
        private readonly DemoHms.Data.ApplicationDbContext _context;
        public IQueryable<Item> Items { get; set; }
        public IQueryable<Department> Departments { get; set; }
        public NewStockController(DemoHms.Data.ApplicationDbContext context)
        {
            _context = context;
        }
        private object MapToGridModel(Stok o)
        {
            Items = _context.Items.AsQueryable();
            Departments = _context.Departments.AsQueryable();
            Item item = null;
            if (o.ItemID != null)
                item = _context.Items.FirstOrDefault(I => I.ItemID == o.ItemID);
            Department department = null;
            if (o.DepartmentID != null)
                department = _context.Departments.FirstOrDefault(I => I.DepartmentID == o.DepartmentID);
            return new
            {
                o.StockID,
                o.Quantity,
                o.Description,
                Items = string.Join(", ", Items.Select(m => m.Name)),
                Item = item != null ? item.Name : "",
                ItemID = o.Item != null ? o.Item.ItemID : 0,

                Departments = string.Join(", ", Departments.Select(n => n.Name)),
                Department = department != null ? department.Name : "",
                DepartmentID = o.Department != null ? o.Department.DepartmentID : 0
            };
        }
        public IActionResult GridGetItems(GridParams g, string search)
        {
            IQueryable<Stok> stocks = null;
            search = (search ?? "").ToLower();
            if (string.IsNullOrWhiteSpace(search))
            {
                stocks = _context.Stoks.AsQueryable();
            }
            else
            {
                stocks = _context.Stoks.Include(S => S.Item).Where(o => o.Item != null && o.Item.Name.ToLower().Contains(search)).AsQueryable();
            }


            var model = new GridModelBuilder<Stok>(stocks, g)
            {
                Key = "StockID", // needed for api select, update, tree, nesting, EF
                GetItem = () => _context.Stoks.FirstOrDefault(T => T.StockID == Convert.ToInt32(g.Key)), // called by the grid.api.update
                Map = MapToGridModel
            }.Build();

            JsonResult jr = new JsonResult(model);
            return jr;
        }
        [HttpPost]
        public IActionResult Create(Stok input)
        {
            if (ModelState.IsValid)
            {
                var item = _context.Items.FirstOrDefault(I => I.ItemID == input.ItemID);
                var department = _context.Departments.FirstOrDefault(I => I.DepartmentID == input.DepartmentID);

                var dinner = new Stok
                {
                    Quantity = input.Quantity,
                    ItemID = item.ItemID,
                    Item = item,
                    DepartmentID = department.DepartmentID,
                    Department = department,
                    Description = input.Description
                };
                _context.Stoks.Add(dinner);
                _context.SaveChanges();

                StockRoutine stockRoutine = new StockRoutine();
                stockRoutine.Quantity = dinner.Quantity;
                stockRoutine.RoutineTypeID = _context.RoutineType.FirstOrDefault(R => R.Name == "New Stock").RoutineTypeID;
                stockRoutine.StockID = dinner.StockID;
                _context.StockRoutines.Add(stockRoutine);
                _context.SaveChanges();


                return new JsonResult(new { Item = MapToGridModel(dinner) });
            }

            return new JsonResult(ModelState.GetErrorsInline());
        }
        [HttpPost]
        public IActionResult Edit(Stok input)
        {
            if (ModelState.IsValid)
            {
                var dinner = _context.Stoks.FirstOrDefault(T => T.StockID == input.StockID);
                dinner.Quantity = dinner.Quantity + input.Quantity;
                dinner.ItemID = input.ItemID;
                dinner.DepartmentID = input.DepartmentID;
                dinner.Description = input.Description;

                StockRoutine stockRoutine = new StockRoutine();
                stockRoutine.Quantity = dinner.Quantity;
                stockRoutine.RoutineTypeID = _context.RoutineType.FirstOrDefault(R => R.Name == "New Stock").RoutineTypeID;
                stockRoutine.StockID = dinner.StockID;
                _context.StockRoutines.Add(stockRoutine);
                _context.SaveChanges();

                _context.Attach(dinner).State = EntityState.Modified;

                _context.SaveChanges();

                return new JsonResult(new { });
            }

            return new JsonResult(ModelState.GetErrorsInline());
        }
        public IActionResult Delete(int StockID)
        {
            var dinner = _context.Stoks.Include(t => t.Department).FirstOrDefault(p => p.StockID == StockID);

            return PartialView("Delete", new DeleteConfirmInput
            {
                Id = StockID,
                Type = "stock",
                Name = dinner.StockID.ToString()
            });
        }
        //[HttpPost]
        public IActionResult Delete(DeleteConfirmInput input)
        {
            _context.Stoks.Remove(_context.Stoks.FirstOrDefault(p => p.StockID == input.Id));
            _context.SaveChanges();

            // the PopupForm's success function utils.itemDeleted expects an obj with "Id" property
            return Json(new { input.Id });
        }
    }
}