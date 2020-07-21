using System.Linq;
using Microsoft.AspNetCore.Mvc;

using AweCoreDemo.Models;

using Omu.AwesomeMvc;
 
namespace AweCoreDemo.Controllers.Demos.Grid
{
    public class GridMaintainSelectionDemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MealsGrid(GridParams g)
        {
            return Json(new GridModelBuilder<Meal>(Db.Meals.AsQueryable(), g).Build());
        }
    }
}