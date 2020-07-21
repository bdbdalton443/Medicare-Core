using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

using AweCoreDemo.Models;

using Omu.AwesomeMvc;
 
namespace AweCoreDemo.Controllers.Awesome.MultiLookup
{
    /*begin*/
    public class MealsCustomSearchMultiLookupController : Controller
    {
        //when CustomSearch(true) this action will be rendered instead of the default search
        public IActionResult SearchForm()
        {
            return PartialView();
        }

        public IActionResult GetItems(IEnumerable<int> v)
        {
            return Json(Db.Meals.Where(o => v != null && v.Contains(o.Id))
                            .Select(f => new KeyContent(f.Id, f.Name)));
        }

        public IActionResult Search(string search, int[] selected, int[] categories, int page)
        {
            const int pageSize = 10;
            selected = selected ?? new int[] { };
            search = (search ?? "").ToLower().Trim();
            categories = categories ?? new int[] { };

            var items = Db.Meals.Where(o => o.Name.ToLower().Contains(search)
                                            && !selected.Contains(o.Id)
                                            && (categories.Contains(o.Category.Id) || categories.Count() == 0));

            return Json(new AjaxListResult
                            {
                                Items = items.Skip((page - 1) * pageSize).Take(pageSize).Select(o => new KeyContent(o.Id, o.Name)),
                                More = items.Count() > page * pageSize
                            });
        }

        public IActionResult Selected(int[] selected)
        {
            selected = selected ?? new int[] { };
            return Json(new AjaxListResult
                            {
                                Items = Db.Meals.Where(o => selected.Contains(o.Id))
                                    .Select(o => new KeyContent(o.Id, o.Name))
                            });
        }
    }
    /*end*/
}