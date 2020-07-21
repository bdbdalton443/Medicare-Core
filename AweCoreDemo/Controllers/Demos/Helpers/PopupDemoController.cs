using Microsoft.AspNetCore.Mvc;

namespace AweCoreDemo.Controllers.Demos.Helpers
{
    public class PopupDemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        /*begin1*/
        public IActionResult Popup1()
        {
            return PartialView();
        }
        /*end1*/

        /*begin2*/
        public IActionResult PopupWithParameters(string parent, int p1, string a, string b, int id)
        {
            ViewData["parent"] = parent;
            ViewData["p1"] = p1;
            ViewData["a"] = a;
            ViewData["b"] = b;
            ViewData["id"] = id;

            return PartialView();
        }
        /*end2*/

        /*begin3*/
        public IActionResult DropdownContent()
        {
            return PartialView();
        }
        /*end3*/

        public IActionResult PopupBtns()
        {
            return PartialView();
        }

        public IActionResult PopupSize()
        {
            return PartialView();
        }

        public IActionResult PopupMod()
        {
            return View();
        }

        public IActionResult DdInPopup()
        {
            return PartialView();
        }
    }
}