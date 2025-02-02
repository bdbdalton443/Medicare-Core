using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AweCoreDemo.Models;
using Omu.AwesomeMvc;
 
namespace AweCoreDemo.Controllers.Awesome.Lookup
{
    /*begin*/
    public class DinnerLookupController : Controller
    {
        // used for custom search when .CustomSearch(true)
        public IActionResult SearchForm()
        {
            return PartialView();
        }

        public IActionResult Search(string search, int page, bool isTheadEmpty, int? pageSize)
        {
            pageSize = pageSize ?? 10;
            search = (search ?? "").ToLower().Trim();

            var list = Db.Dinners.Where(o => o.Name.ToLower().Contains(search))
                .OrderByDescending(o => o.Id);

            var result = new AjaxListResult
            {
                Content = this.RenderPartialView("ListItems/Dinner", list.Skip((page - 1) * pageSize.Value).Take(pageSize.Value)),
                More = list.Count() > page * pageSize
            };

            if (isTheadEmpty) result.Thead = this.RenderPartialView("ListItems/DinnerThead");
            return Json(result);
        }

        public IActionResult GetItem(int? v)
        {
            var o = v == null || v == 0 ? new Dinner() : Db.Get<Dinner>(v);

            return Json(new KeyContent(o.Id, o.Name));
        }
    }
    /*end*/
}