using Microsoft.AspNetCore.Mvc;

using AweCoreDemo.ViewModels.Input;

namespace AweCoreDemo.Controllers.Demos.Grid
{
    public class GridShowHideColumnsDemoController : Controller
    {
        public IActionResult Index()
        {
            return View(new GridHideColumnsDemoInput{ ShowFood = true, ShowLocation = true });
        }

        public IActionResult GridContent(GridHideColumnsDemoInput input)
        {
            return PartialView(input);
        }
    }
}