using Microsoft.AspNetCore.Mvc;

using AweCoreDemo.ViewModels.Input;

namespace AweCoreDemo.Controllers.Demos.Helpers
{
    public class MultiLookupDemoController : Controller
    {
        public IActionResult Index()
        {
            return View(new MultiLookupDemoCfgInput
            {
                HighlightChange = true,
                DragAndDrop = true
            });
        }

        [HttpPost]
        public IActionResult IndexContent(MultiLookupDemoCfgInput input)
        {
            return PartialView(input);
        }

        public IActionResult CustomSearch()
        {
            return View();
        }

        public IActionResult Misc()
        {
            return View();
        }

        public IActionResult MealMultiLookup()
        {
            return PartialView();
        }
    }
}