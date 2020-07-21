using Microsoft.AspNetCore.Mvc;
using AweCoreDemo.ViewModels.Input;

namespace AweCoreDemo.Controllers.Demos.Helpers
{
    public class TextBoxDemoController : Controller
    {
        public IActionResult Index()
        {
            return View(new TextBoxDemoInput());
        }
    }
}