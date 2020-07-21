using Microsoft.AspNetCore.Mvc;

using AweCoreDemo.Models;
using AweCoreDemo.ViewModels.Input;

namespace AweCoreDemo.Controllers.Demos.Helpers
{
    public class AjaxCheckboxListDemoController : Controller
    {
        public IActionResult Index()
        {
            return View(new AjaxCheckboxListDemoInput
                {
                    CategoryData = Db.Categories[0].Id,
                    ParentCategory = new[] { Db.Categories[0].Id }
                });
        }
    }
}