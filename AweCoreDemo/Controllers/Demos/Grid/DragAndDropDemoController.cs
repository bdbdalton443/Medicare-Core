using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AweCoreDemo.Models;
using Omu.AwesomeMvc;
 
namespace AweCoreDemo.Controllers.Demos.Grid
{
    public class DragAndDropDemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        /*begin*/
        public IActionResult MealsGridSrc(GridParams g, int[] selected)
        {
            selected = selected ?? new int[] {};
            var items = Db.Meals.Where(o => !selected.Contains(o.Id)).AsQueryable();
            return Json(new GridModelBuilder<Meal>(items, g) { Key = "Id" }.Build());
        }

        public IActionResult MealsGridSel(GridParams g, int[] selected)
        {
            selected = selected ?? new int[] { };
            var items = Db.Meals.Where(o => selected.Contains(o.Id)).AsQueryable();
            return Json(new GridModelBuilder<Meal>(items, g) { Key = "Id" }.Build());
        }
        /*end*/
    }
}