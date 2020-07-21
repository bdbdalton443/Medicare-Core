using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

using AweCoreDemo.Models;

using Omu.AwesomeMvc;
 
namespace AweCoreDemo.Controllers.Awesome.MultiLookup
{
    public class MealsCustomItemMultiLookupController : Controller
    {
        public IActionResult SearchForm()
        {
            return PartialView();
        }

        public IActionResult GetItems(IEnumerable<int> v)
        {
            return Json(Db.Meals.Where(o => v != null && v.Contains(o.Id))
                          .Select(f => new KeyContent(f.Id, f.Name)));
        }

        public IActionResult Search(string search, int[] selected, int page)
        {
            const int pageSize = 10;
            selected = selected ?? new int[] { };
            search = (search ?? "").ToLower().Trim();

            var items = Db.Meals.Where(o => o.Name.ToLower().Contains(search)
                                            && (!selected.Contains(o.Id)));
            
            //instead of setting the Items property we set the Content with rendered html
            return Json(new AjaxListResult
                {
                    Content = this.RenderPartialView("items", items.Skip((page - 1) * pageSize).Take(pageSize)),
                    More = items.Count() > page * pageSize
                });
        }

        public IActionResult Selected(IEnumerable<int> selected)
        {
            return Json(new AjaxListResult
                {
                    Content = this.RenderPartialView("items", Db.Meals.Where(o => selected != null && selected.Contains(o.Id)))
                });
        }

        //used by the details button, in items view
        public IActionResult Details(int id)
        {
            return PartialView(Db.Get<Meal>(id));
        }
    }
}