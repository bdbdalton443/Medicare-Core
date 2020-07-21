using System.Linq;
using Microsoft.AspNetCore.Mvc;

using AweCoreDemo.Models;
using AweCoreDemo.Utils;
using Omu.AwesomeMvc;
 
namespace AweCoreDemo.Controllers.Awesome.Lookup
{
    /*begin*/
    public class MealLookupController : Controller
    {
        public IActionResult GetItem(int? v)
        {
            Check.NotNull(v, "v");
            var o = Db.Meals.SingleOrDefault(f => f.Id == v) ?? new Meal();

            return Json(new KeyContent(o.Id, o.Name));
        }

        public IActionResult Search(string search, int page)
        {
            const int PageSize = 7;
            search = (search ?? "").ToLower().Trim();
            
            var list = Db.Meals.Where(o => o.Name.ToLower().Contains(search));

            return Json(new AjaxListResult
                            {
                                Items = list.Skip((page - 1) * PageSize).Take(PageSize).Select(o => new KeyContent(o.Id, o.Name)),
                                More = list.Count() > page * PageSize
                            });
        }
    }
    /*end*/
}