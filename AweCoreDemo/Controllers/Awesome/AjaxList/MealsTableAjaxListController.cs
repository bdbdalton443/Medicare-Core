using System.Linq;
using Microsoft.AspNetCore.Mvc;

using AweCoreDemo.Models;

using Omu.AwesomeMvc;
 
namespace AweCoreDemo.Controllers.Awesome.AjaxList
{
    /*begin*/
    public class MealsTableAjaxListController : Controller
    {
        //isTheadEmpty is sent only when .TableLayout(true)
        public IActionResult Search(int[] categories, string name, string orderby, int page, bool isTheadEmpty)
        {
            categories = categories ?? new int[] { };
            name = (name ?? string.Empty).ToLower().Trim();

            const int PageSize = 10;

            var list = Db.Meals.Where(o =>
                (!categories.Any() || o.Category != null && categories.Contains(o.Category.Id))
                && o.Name.ToLower().Contains(name)).OrderByDescending(o => o.Id);

            if (orderby == "Name") list = list.OrderBy(o => o.Name);
            if (orderby == "Category") list = list.OrderBy(o => o.Category.Name);
            
            var result = new AjaxListResult
                        {
                            Content = this.RenderView("ListItems/MealCrud", list.Skip((page - 1) * PageSize).Take(PageSize)),
                            More = list.Count() > page * PageSize
                        };

            if (isTheadEmpty) result.Thead = this.RenderView("ListItems/MealCrudThead");

            return Json(result);
        }
    }
    /*end*/
}