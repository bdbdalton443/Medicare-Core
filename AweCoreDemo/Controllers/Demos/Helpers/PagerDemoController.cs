using System.Linq;
using Microsoft.AspNetCore.Mvc;

using AweCoreDemo.Models;

namespace AweCoreDemo.Controllers.Demos.Helpers
{
    /*begin*/
    public class PagerDemoController : Controller
    {
        public IActionResult Index(int page = 1)
        {
            const int PageSize = 1;
            var pageCount = (Db.Meals.Count + PageSize - 1) / PageSize;

            ViewData["page"] = page;
            ViewData["count"] = pageCount;

            return View(Db.Meals.Skip((page - 1) * PageSize).Take(PageSize));
        }
    }
    /*end*/
}