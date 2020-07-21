using System.Linq;
using Microsoft.AspNetCore.Mvc;

using AweCoreDemo.Models;
using AweCoreDemo.Utils;
using Omu.AwesomeMvc;
 
namespace AweCoreDemo.Controllers.Awesome.Lookup
{
    /*begin*/
    public class MealCustomSearchLookupController : Controller
    {
        public IActionResult SearchForm()
        {
            return PartialView();
        }

        public IActionResult GetItem(int? v)
        {
            Check.NotNull(v, "v");
            var o = Db.Meals.SingleOrDefault(f => f.Id == v) ?? new Meal();

            return Json(new KeyContent(o.Id, o.Name));
        }

        public IActionResult Search(string search, int[] categories, int page)
        {
            const int PageSize = 10;
            search = (search ?? "").ToLower().Trim();
            categories = categories ?? new int[] { };

            var list = Db.Meals.Where(f => f.Name.ToLower().Contains(search) //give list of meals where name contains search
             && (!categories.Any() || f.Category != null && categories.Contains(f.Category.Id)));// if categories specified, filter by them
            return Json(new AjaxListResult
                            {
                                Items = list.Skip((page - 1) * PageSize).Take(PageSize).Select(o => new KeyContent(o.Id, o.Name)),
                                More = list.Count() > page * PageSize
                            });
        }
    }
    /*end*/
}