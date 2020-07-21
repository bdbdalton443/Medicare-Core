using System.Linq;
using Microsoft.AspNetCore.Mvc;

using AweCoreDemo.Models;
using AweCoreDemo.ViewModels.Input;

namespace AweCoreDemo.Controllers.Demos.Generic
{
    public class ListBindingController : Controller
    {
        public IActionResult Index()
        {
            return View(new ListBindingInput {Dinners = Db.Dinners.Take(3).Select(o => new DinnerInput
                                                           {
                                                               Id = o.Id,
                                                               Name = o.Name,
                                                               Date = o.Date,
                                                               Chef = o.Chef.Id,
                                                               Meals = o.Meals.Select(m => m.Id)
                                                           }).ToList()});
        }

        [HttpPost]
        public IActionResult Index(ListBindingInput input)
        {
            return View(input);
        }
    }
}