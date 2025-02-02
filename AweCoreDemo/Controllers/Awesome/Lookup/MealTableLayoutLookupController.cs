using System.Linq;
using Microsoft.AspNetCore.Mvc;

using AweCoreDemo.Models;
using AweCoreDemo.Utils;
using Omu.AwesomeMvc;
 
namespace AweCoreDemo.Controllers.Awesome.Lookup
{
    public class MealTableLayoutLookupController : Controller
    {
        public IActionResult GetItem(int? v)
        {
            Check.NotNull(v, "v");
            var o = Db.Meals.SingleOrDefault(f => f.Id == v) ?? new Meal();

            return Json(new KeyContent(o.Id, o.Name));
        }

        //when using TableLayout(true) we will get a isTheadEmpty bool variable
        //which will tell us wheter the table header is empty
        public IActionResult Search(string search, int page, bool isTheadEmpty)
        {
            const int PageSize = 5;
            search = (search ?? "").ToLower().Trim();
            var list = Db.Meals.Where(f => f.Name.ToLower().Contains(search));
            var result = new AjaxListResult
                {
                    Content = this.RenderView("ListItems/Meal", list.Skip((page - 1) * PageSize).Take(PageSize)),
                    More = list.Count() > page * PageSize
                };
            //setting the table header with rendered html
            if (isTheadEmpty) result.Thead = this.RenderView("ListItems/MealThead");

            return Json(result);
        }
    }
}