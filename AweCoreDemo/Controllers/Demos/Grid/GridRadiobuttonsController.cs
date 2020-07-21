using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AweCoreDemo.Models;
using Omu.AwesomeMvc;
 
namespace AweCoreDemo.Controllers.Demos.Grid
{
    public class GridRadioButtonsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GridGetItems(GridParams g, string search)
        {
            search = (search ?? "").ToLower();
            var items = Db.Dinners.Where(o => o.Name.ToLower().Contains(search)).AsQueryable();
        
            var model = new GridModelBuilder<Dinner>(items, g)
            {
                KeyProp = o => o.Id,
                Map = MapToGridModel,
            }.Build();

            return Json(model);
        }

        private object MapToGridModel(Dinner o)
        {
            return new
            {
                o.Id,
                o.Name,
                BonusMealId = o.BonusMeal.Id,
            };
        }
    }
}