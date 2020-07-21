using System.Linq;
using Microsoft.AspNetCore.Mvc;

using AweCoreDemo.Models;

using Omu.AwesomeMvc;
 
namespace AweCoreDemo.Controllers.Awesome.Autocomplete
{
    public class CategoryAutocompleteController : Controller
    {
        public IActionResult GetItems(string v)
        {
            v = (v ?? "").ToLower().Trim();
            return Json(Db.Categories.Where(o => o.Name.ToLower().Contains(v))
                          .Select(o => new KeyContent(o.Id, o.Name)));
        }
    }
}