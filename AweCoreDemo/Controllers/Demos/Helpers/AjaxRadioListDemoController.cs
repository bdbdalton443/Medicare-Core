using Microsoft.AspNetCore.Mvc;

using AweCoreDemo.Models;
using AweCoreDemo.ViewModels.Input;

namespace AweCoreDemo.Controllers.Demos.Helpers
{
    public class AjaxRadioListDemoController : Controller
    {
        public IActionResult Index()
        {
            return View(new AjaxDropdownDemoInput
                {
                    ParentCategory = Db.Categories[0].Id, 
                    Category2 = Db.Categories[0].Id,
                    Category = Db.Categories[0].Id
                });
        }
    }
}