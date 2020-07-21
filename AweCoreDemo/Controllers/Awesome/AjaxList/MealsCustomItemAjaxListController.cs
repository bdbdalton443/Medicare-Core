using System.Linq;
using Microsoft.AspNetCore.Mvc;

using AweCoreDemo.Models;

using Omu.AwesomeMvc;
 
namespace AweCoreDemo.Controllers.Awesome.AjaxList
{
    /*begin*/
    public class MealsCustomItemAjaxListController : Controller
    {
        public IActionResult Search(int page)
        {
            const int PageSize = 5;
            return Json(new AjaxListResult
                            {
                                Content = this.RenderView("CustomItem", Db.Meals.Skip((page - 1) * PageSize).Take(PageSize).ToList()),
                                More = Db.Meals.Count > (page * PageSize)
                            });
        }
    }
    /*end*/
}