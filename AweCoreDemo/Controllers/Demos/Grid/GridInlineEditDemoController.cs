using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

using AweCoreDemo.Models;
using AweCoreDemo.ViewModels.Input;
using Omu.Awem.Utils;
using Omu.AwesomeMvc;
using DemoHms.Data;
using Microsoft.EntityFrameworkCore;

namespace AweCoreDemo.Controllers.Demos.Grid
{ 
    public class GridInlineEditDemoController : Controller
    {
        private readonly DemoHms.Data.ApplicationDbContext _context;
        public GridInlineEditDemoController(DemoHms.Data.ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ConditionalDemo()
        {
            return View();
        }

        public IActionResult MultiEditorsDemo()
        {
            return View();
        }

        private object MapToGridModel(Dinner o)
        {
            return new
            {
                o.Id,
                o.Name,
                Date = o.Date.ToShortDateString(),
                ChefName = o.Chef.FirstName + " " + o.Chef.LastName,
                Meals = string.Join(", ", o.Meals.Select(m => m.Name)),
                BonusMeal = o.BonusMeal.Name,
                o.Organic,
                DispOrganic = o.Organic ? "Yes" : "No",

                // below properties used for inline editing only
                MealsIds = o.Meals.Select(m => m.Id).ToArray(),
                ChefId = o.Chef.Id,
                BonusMealId = o.BonusMeal.Id,

                // for conditional demo
                Editable = o.Meals.Count() > 1,
                DateReadOnly = o.Date.Year < 2012
            };
        }

        public IActionResult GridGetItems(GridParams g, string search)
        {
            search = (search ?? "").ToLower();
            var items = Db.Dinners.Where(o => o.Name.ToLower().Contains(search)).AsQueryable();
            
            var model = new GridModelBuilder<Dinner>(items, g)
            {
                Key = "Id", // needed for api select, update, tree, nesting, EF
                GetItem = () => Db.Get<Dinner>(Convert.ToInt32(g.Key)), // called by the grid.api.update
                Map = MapToGridModel,
            }.Build();

            return Json(model);
        }

        [HttpPost]
        public IActionResult Create(DinnerInput input)
        {
            if (ModelState.IsValid)
            {
                var dinner = new Dinner
                {
                    Name = input.Name,
                    Date = input.Date.Value,
                    Chef = Db.Get<Chef>(input.Chef),
                    Meals = input.Meals.Select(mid => Db.Get<Meal>(mid)),
                    BonusMeal = Db.Get<Meal>(input.BonusMealId),
                    Organic = input.Organic ?? false
                };

                Db.Insert(dinner);

                return Json(new { Item = MapToGridModel(dinner) });
            }

            return Json(ModelState.GetErrorsInline());
        }

        [HttpPost]
        public IActionResult Edit(DinnerInput input)
        {
            if (ModelState.IsValid)
            {
                var dinner = Db.Get<Dinner>(input.Id);
                dinner.Name = input.Name;
                dinner.Date = input.Date.Value;
                dinner.Chef = Db.Get<Chef>(input.Chef);

                dinner.Meals = input.Meals.Select(mid => Db.Get<Meal>(mid));

                dinner.BonusMeal = Db.Get<Meal>(input.BonusMealId);
                dinner.Organic = input.Organic ?? false;
                Db.Update(dinner);

                return Json(new { });
            }

            return Json(ModelState.GetErrorsInline());
        }
        private object MapToGridModel1(Procedure arg)
        {
            return new
            {
                arg.ProcedureID,
                arg.Description,
                arg.Findings,
                Tests = string.Join(", ", _context.Tests.Select(m => m.Name)),
                Test = arg.Test != null ? arg.Test.Name : "",               
                TestID = arg.Test != null ? arg.Test.TestID : 0
            };
        }
        public IActionResult GridGetItems1(GridParams g, string search)
        {
            search = (search ?? "").ToLower();
            var procedures = _context.Procedures.Include(t=>t.Test).Where(o => o.Test.Name.ToLower().Contains(search)).AsQueryable();

            var model = new GridModelBuilder<Procedure>(procedures, g)
            {
                Key = "ProcedureID", // needed for api select, update, tree, nesting, EF
                GetItem = () => _context.Procedures.FirstOrDefault(p=>p.ProcedureID==Convert.ToInt32(g.Key)), // called by the grid.api.update
                Map = MapToGridModel1,
            }.Build();

            return Json(model);
        }
        [HttpPost]
        public IActionResult Create1(Procedure input)
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

                return new JsonResult(new { Item = MapToGridModel1(dinner) });
            }

            return new JsonResult(ModelState.GetErrorsInline());
        }
        [HttpPost]
        public IActionResult Edit1(Procedure input)
        {
            if (ModelState.IsValid)
            {
                var dinner = _context.Procedures.FirstOrDefault(T => T.ProcedureID == input.ProcedureID);
                dinner.Description = input.Description;
                dinner.Findings = input.Findings;
                dinner.TestID = input.TestID;
                //Organic = input.Organic ?? false

                _context.Attach(dinner).State = EntityState.Modified;

                _context.SaveChangesAsync();

                return new JsonResult(new { });
            }

            return new JsonResult(ModelState.GetErrorsInline());
        }
        public IActionResult Delete1(int id)
        {
            var dinner = _context.Procedures.Include(t=>t.Test).FirstOrDefault(p=>p.ProcedureID==id);

            return PartialView("Delete", new DeleteConfirmInput
            {
                Id = id,
                Type = "dinner",
                Name = dinner.Test.Name
            });
        }
        [HttpPost]
        public IActionResult Delete1(DeleteConfirmInput input)
        {
           _context.Procedures.Remove(_context.Procedures.FirstOrDefault(p=>p.ProcedureID==input.Id));
            _context.SaveChanges();

            // the PopupForm's success function utils.itemDeleted expects an obj with "Id" property
            return Json(new { input.Id });
        }
        public IActionResult Delete(int id)
        {
            var dinner = Db.Get<Dinner>(id);

            return PartialView(new DeleteConfirmInput
            {
                Id = id,
                Type = "dinner",
                Name = dinner.Name
            });
        }


        [HttpPost]
        public IActionResult Delete(DeleteConfirmInput input)
        {
            Db.Delete<Dinner>(input.Id);

            // the PopupForm's success function utils.itemDeleted expects an obj with "Id" property
            return Json(new { input.Id });
        }

        public IActionResult Popup()
        {
            return PartialView();
        }
    }
}