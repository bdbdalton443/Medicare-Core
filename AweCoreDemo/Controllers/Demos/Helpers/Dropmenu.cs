using Microsoft.AspNetCore.Mvc;

namespace AweCoreDemo.Controllers.Demos.Helpers
{
    public class DropmenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Popup1()
        {
            return PartialView();
        }
    }
}