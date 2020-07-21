using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AweCoreDemo.Models;

namespace AweCoreDemo.Controllers.Demos.Grid
{
    public class GridCrudDemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ClientData()
        {
            return View();
        }

        public IActionResult GetItem(int id)
        {
            var item = Db.Dinners.Where(o => o.Id == id).Select(o => new
            {
                o.Id,
                o.Name,
                o.Date,
                o.Chef,
                DateStr = o.Date.ToShortDateString(),
                ChefName = o.Chef.FirstName + " " + o.Chef.LastName,
                Meals = string.Join(", ", o.Meals.Select(m => m.Name))
            });

            return Json(item);
        }
    }
}