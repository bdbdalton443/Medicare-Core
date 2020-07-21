using System.Linq;
using Microsoft.AspNetCore.Mvc;

using AweCoreDemo.Models;
using Omu.AwesomeMvc;
 
namespace AweCoreDemo.Controllers.Awesome.MultiLookup
{
    /*begin*/
    public class DinnerMultiLookupController : Controller
    {
        // used for custom search when .CustomSearch(true)
        public IActionResult SearchForm()
        {
            return PartialView();
        }

        public IActionResult Search(string search, int page, bool isTheadEmpty, int[] selected)
        {
            var pageSize = 10;
            selected = selected ?? new int[] { };

            search = (search ?? "").ToLower().Trim();

            var list = Db.Dinners.Where(o => o.Name.ToLower().Contains(search) && !selected.Contains(o.Id))
                         .OrderByDescending(o => o.Id);

            var result = new AjaxListResult
            {
                Content = this.RenderPartialView("ListItems/DinnerMulti", list.Skip((page - 1) * pageSize).Take(pageSize)),
                More = list.Count() > page * pageSize
            };

            if (isTheadEmpty) result.Thead = this.RenderPartialView("ListItems/DinnerThead");
            return Json(result);
        }

        public IActionResult GetItems(int[] v)
        {
            v = v ?? new int[] {};
            return Json(Db.Dinners.Where(o => v.Contains(o.Id))
                .Select(o => new KeyContent(o.Id, o.Name)));
        }

        public IActionResult Selected(int[] selected, bool isTheadEmpty)
        {
            selected = selected ?? new int[] {};
            var items = Db.Dinners.Where(o => selected.Contains(o.Id));

            var result = new AjaxListResult
            {
                Content = this.RenderPartialView("ListItems/DinnerMulti", items),
            };

            if (isTheadEmpty) result.Thead = this.RenderPartialView("ListItems/DinnerThead");

            return Json(result);
        }
    }
    /*end*/
}