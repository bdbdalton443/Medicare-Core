using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AweCoreDemo.Models;
using AweCoreDemo.ViewModels.Input;
using Omu.AwesomeMvc;
 
namespace AweCoreDemo.Controllers.Demos.Misc
{
    public class CrudInLookupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LookupCrudDemoInput input)
        {
            return View(input);
        }

        public IActionResult DinnerLookup()
        {
            return PartialView();
        }

        public IActionResult DinnerMultiLookup()
        {
            return PartialView();
        }

        private static object MapToGridModel(Dinner o)
        {
            return
                new
                {
                    o.Id,
                    o.Name,
                    Date = o.Date.ToShortDateString(),
                    ChefName = o.Chef.FirstName + " " + o.Chef.LastName,
                    Meals = string.Join(", ", o.Meals.Select(m => m.Name))
                };
        }
        
        public IActionResult DinnersGridSearch(GridParams g, string search, int[] selected)
        {
            search = (search ?? "").ToLower();
            selected = selected ?? new int[] { };

            var items = Db.Dinners.Where(o => o.Name.ToLower().Contains(search) && !selected.Contains(o.Id)).AsQueryable();

            return Json(new GridModelBuilder<Dinner>(items, g)
            {
                KeyProp = o => o.Id,
                GetItem = () => Db.Get<Dinner>(Convert.ToInt32(g.Key)),
                Map = MapToGridModel
            }.Build());
        }
        
        public IActionResult DinnersGridSelected(GridParams g, int[] selected)
        {
            selected = selected ?? new int[] { };

            var items = Db.Dinners.Where(o => selected.Contains(o.Id)).AsQueryable();

            return Json(new GridModelBuilder<Dinner>(items, g)
            {
                KeyProp = o => o.Id,
                GetItem = () => Db.Get<Dinner>(Convert.ToInt32(g.Key)),
                Map = MapToGridModel
            }.Build());
        }
    }
}