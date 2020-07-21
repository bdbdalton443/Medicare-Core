using System.Linq;
using Microsoft.AspNetCore.Mvc;

using AweCoreDemo.Models;

using Omu.AwesomeMvc;
 
namespace AweCoreDemo.Controllers.Awesome.AjaxList
{
    /*begin*/
    public class MealsAjaxListController : Controller
    {
        public IActionResult Search(int page, string parent)
        {
            const int PageSize = 5;
            parent = (parent ?? "").ToLower();

            var list = Db.Meals.Where(o => o.Name.ToLower().Contains(parent));

            return Json(new AjaxListResult
                            {
                                Items = list.Skip((page - 1) * PageSize).Take(PageSize).Select(o => new KeyContent(o.Id, o.Name)),
                                More = list.Count() > page * PageSize // bool - show More button or not
                            });
        }
    }
    /*end*/
}