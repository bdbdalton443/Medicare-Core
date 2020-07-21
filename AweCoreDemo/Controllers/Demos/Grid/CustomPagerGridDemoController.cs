using Microsoft.AspNetCore.Mvc;

namespace AweCoreDemo.Controllers.Demos.Grid
{
    public class CustomPagerGridDemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}