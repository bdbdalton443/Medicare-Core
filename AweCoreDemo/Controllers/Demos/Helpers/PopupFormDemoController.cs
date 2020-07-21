using Microsoft.AspNetCore.Mvc;

using AweCoreDemo.ViewModels.Input;

namespace AweCoreDemo.Controllers.Demos.Helpers
{
    public class PopupFormDemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        /*begin*/
        public IActionResult PopupWithParameters(int? id, string parent, int p1, string a, string b)
        {
            ViewData["parent"] = parent;
            ViewData["p1"] = p1;
            ViewData["a"] = a;
            ViewData["b"] = b;
            ViewData["id"] = id;
            return PartialView();
        }

        [HttpPost]
        public IActionResult PopupWithParameters()
        {
            return Json(new { });
        }
        /*end*/

        public IActionResult PopupConfirm()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult PopupConfirm(PopupConfirmInput input)
        {
            return Json(new { input.Name });
        }
    }
}