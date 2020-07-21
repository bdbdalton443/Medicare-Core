using Microsoft.AspNetCore.Mvc;

using AweCoreDemo.ViewModels.Input;

namespace AweCoreDemo.Controllers.Demos.Helpers
{
    public class LookupDemoController : Controller
    {
        public IActionResult Index()
        {
            return View(new LookupDemoCfgInput
                            {
                                HighlightChange = true,
                                ClearButton = true
                            });
        }

        [HttpPost]
        public IActionResult IndexContent(LookupDemoCfgInput input)
        {
            return PartialView(input);
        }

        public IActionResult CustomSearch()
        {
            return View();
        }

        public IActionResult Misc()
        {
            return View(new LookupDemoInput());
        }

        public IActionResult MealLookup()
        {
            return PartialView();
        }
    }
}