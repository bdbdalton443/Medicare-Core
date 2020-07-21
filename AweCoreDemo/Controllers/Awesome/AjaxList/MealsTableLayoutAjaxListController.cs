using System.Linq;
using Microsoft.AspNetCore.Mvc;

using AweCoreDemo.Models;

using Omu.AwesomeMvc;
 
namespace AweCoreDemo.Controllers.Awesome.AjaxList
{
    /*begin*/
    public class MealsTableLayoutAjaxListController : Controller
    {
        public IActionResult Search(int page, bool isTheadEmpty)
        {
            const int PageSize = 5;
            var result = new AjaxListResult
                             {
                                 Content = this.RenderView("CustomItems", Db.Meals.Skip((page - 1) * PageSize).Take(PageSize)),
                                 More = Db.Meals.Count > page * PageSize
                             };

            if (isTheadEmpty) result.Thead = this.RenderView("TableHeader");

            return Json(result);
        }
    }
    /*end*/
}