using Microsoft.AspNetCore.Mvc;

namespace AweCoreDemo.Controllers.Demos.Misc
{
    public class AngularDemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}