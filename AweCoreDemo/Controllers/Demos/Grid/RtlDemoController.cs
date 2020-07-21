using Microsoft.AspNetCore.Mvc;

using AweCoreDemo.ViewModels.Input;

namespace AweCoreDemo.Controllers.Demos.Grid
{
    public class RtlDemoController : Controller
    {
        public IActionResult Index()
        {
            return View(new UnobtrusiveInput());
        }

        [HttpPost]
        public IActionResult Index(UnobtrusiveInput input)
        {
            return View(input);
        }
    }
}