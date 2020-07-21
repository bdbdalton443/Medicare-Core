using Microsoft.AspNetCore.Mvc;

using AweCoreDemo.Models;
using AweCoreDemo.ViewModels.Input;

namespace AweCoreDemo.Controllers.Demos.Helpers
{
    public class AjaxDropdownDemoController : Controller
    {
        public IActionResult Index()
        {
            return View(new AjaxDropdownDemoInput {Category = Db.Categories[0].Id, Category1 = Db.Categories[0].Id });
        }
    }
}