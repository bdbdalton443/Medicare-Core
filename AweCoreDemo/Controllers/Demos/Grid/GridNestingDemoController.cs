using Microsoft.AspNetCore.Mvc;

using AweCoreDemo.Models;

namespace AweCoreDemo.Controllers.Demos.Grid
{
    public class GridNestingDemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        /*begin1*/
        public IActionResult LunchDetail(int key)
        {
            var lunch = Db.Get<Lunch>(key);
            return PartialView(lunch);
        }
        /*end1*/

        /*begin*/
        public IActionResult MealGrid(int key)
        {
            ViewData["Id"] = key;
            return PartialView();
        }
        /*end*/
    }
}