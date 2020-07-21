using System.Linq;
using Microsoft.AspNetCore.Mvc;

using AweCoreDemo.Models;

using Omu.AwesomeMvc;
 
namespace AweCoreDemo.Controllers.Awesome.MultiLookup
{
    public class MealsTableLayoutMultiLookupController : Controller
    {
        public IActionResult GetItems(int[] v)
        {
            v = v ?? new int[] { };
            return Json(Db.Meals.Where(f => v.Contains(f.Id)).Select(o => new KeyContent(o.Id, o.Name)));
        }

        //when using TableLayout(true) we will get a isTheadEmpty bool variable
        //which will tell us whether the table header is empty
        public IActionResult Search(string search, int[] selected, int page, bool isTheadEmpty)
        {
            const int pageSize = 5;
            search = (search ?? "").ToLower().Trim();
            selected = selected ?? new int[] { };

            var list = Db.Meals.Where(o => o.Name.ToLower().Contains(search) && !selected.Contains(o.Id));

            //viewdata will be passed to RenderView
            //in meal view there's a check for ViewData["multilookup"]
            // if it's not null the move button for the multilookup will be rendered
            ViewData["multilookup"] = true;

            var result = new AjaxListResult
            {
                Content = this.RenderView("ListItems/Meal", list.Skip((page - 1) * pageSize).Take(pageSize)),
                More = list.Count() > page * pageSize
            };

            //setting the table header with rendered html
            if (isTheadEmpty) result.Thead = this.RenderView("ListItems/MealThead");

            return Json(result);
        }

        public IActionResult Selected(int[] selected, bool isTheadEmpty)
        {
            selected = selected ?? new int[] { };
            ViewData["multilookup"] = true; // used in ListItems/Meal.cshtml

            var result = new AjaxListResult
            {
                Content = this.RenderPartialView("ListItems/Meal", Db.Meals.Where(o => selected.Contains(o.Id)))
            };

            if (isTheadEmpty)
            {
                result.Thead = this.RenderPartialView("ListItems/MealThead");
            }

            return Json(result);
        }
    }
}