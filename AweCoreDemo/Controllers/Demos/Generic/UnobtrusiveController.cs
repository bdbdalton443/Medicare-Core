using Microsoft.AspNetCore.Mvc;

using AweCoreDemo.ViewModels.Input;

namespace AweCoreDemo.Controllers.Demos.Generic
{
    public class UnobtrusiveController : Controller
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