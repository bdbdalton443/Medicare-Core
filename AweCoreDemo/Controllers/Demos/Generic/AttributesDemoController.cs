using System.Linq;
using Microsoft.AspNetCore.Mvc;

using AweCoreDemo.Models;
using AweCoreDemo.ViewModels.Input;

namespace AweCoreDemo.Controllers.Demos.Generic
{
    public class AttributesDemoController : Controller
    {
        public IActionResult Index()
        {
            return View(new AttributesDemoInput { ParentCategory = Db.Categories.First().Id });
        }

        [HttpPost]
        public IActionResult Index(AttributesDemoInput input)
        {
            return View(input);
        }
    }
}