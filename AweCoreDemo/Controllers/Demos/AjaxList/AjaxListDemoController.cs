using Microsoft.AspNetCore.Mvc;

namespace AweCoreDemo.Controllers.Demos.AjaxList
{
    public class AjaxListDemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CustomItemTemplate()
        {
            return View();
        }

        public IActionResult TableLayout()
        {
            return View();
        }

        public IActionResult ClientSideApi()
        {
            return View();
        }

        public IActionResult Crud()
        {
            return View();
        }
    }
}