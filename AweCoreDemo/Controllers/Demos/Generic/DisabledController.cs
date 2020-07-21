using Microsoft.AspNetCore.Mvc;

namespace AweCoreDemo.Controllers.Demos.Generic
{
    public class DisabledController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}