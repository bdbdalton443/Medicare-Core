using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AweCoreDemo.ViewModels.Input;

namespace AweCoreDemo.Controllers.Demos.Helpers
{
    public class FormDemoController : Controller
    {
        public IActionResult Index(FormDemoInput input)
        {
            ViewData["word"] = input.Word;
            return View();
        }

        [HttpPost]
        public IActionResult Index(string word)
        {
            return RedirectToAction("Index", new { Word = word });
        }

/*begin*/
        [HttpPost]
        public IActionResult AskName(AskNameInput input)
        {
            if (input.Delay)
            {
                Task.Delay(2000).Wait();
            }

            if (!ModelState.IsValid) return View(input);
            
            return Json(new { Name = input.FName + " " + input.LName });
        }
/*end*/

        [HttpPost]
        public IActionResult FillForm(SayInput input)
        {
            return Content("You said " + input.SaySomething);
        }
    }
}