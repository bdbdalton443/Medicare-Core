using System.Linq;
using Microsoft.AspNetCore.Mvc;

using AweCoreDemo.Models;

using Omu.AwesomeMvc;
 
namespace AweCoreDemo.Controllers.Awesome.AjaxDropdown
{
    /*begin*/
    public class ApiMealAjaxDropdownController : Controller
    {
        public IActionResult GetItems(int? v, string text = "ma")
        {
            var items = Db.Meals.Where(o => o.Name.ToLower().Contains(text.ToLower()))
                          .Select(o => new KeyContent(o.Id, o.Name));

            return Json(items);
        }
    }/*end*/
}