using System.Linq;
using Microsoft.AspNetCore.Mvc;

using AweCoreDemo.Models;

using Omu.AwesomeMvc;
 
namespace AweCoreDemo.Controllers.Awesome.Autocomplete
{
    public class MealAutocompleteController : Controller
    {
        public IActionResult GetItems(string v)// v is the entered text
        {
            v = (v ?? "").ToLower().Trim();
            
            var items = Db.Meals.Where(o => o.Name.ToLower().Contains(v));

            return Json(items.Take(10).Select(o => new KeyContent(o.Id, o.Name)));
        }
    }
}