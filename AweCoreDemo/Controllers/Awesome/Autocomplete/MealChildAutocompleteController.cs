using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AweCoreDemo.Models;
using Omu.AwesomeMvc;
 
namespace AweCoreDemo.Controllers.Awesome.Autocomplete
{
    public class MealChildAutocompleteController : Controller
    {
        public IActionResult GetItems(string v, int[] parent)
        {
            v = (v ?? "").ToLower().Trim();
            parent = parent ?? new int[] { };

            var items = Db.Meals.Where(o => o.Name.ToLower().Contains(v));
            items = items.Where(o => parent.Contains(o.Category.Id));

            return Json(items.Take(10).Select(o => new KeyContent(o.Id, o.Name)));
        }
    }
}