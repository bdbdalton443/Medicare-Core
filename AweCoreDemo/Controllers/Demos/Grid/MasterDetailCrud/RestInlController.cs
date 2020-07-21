using Microsoft.AspNetCore.Mvc;
using AweCoreDemo.Models;
using AweCoreDemo.ViewModels.Input;
using Omu.Awem.Utils;

namespace AweCoreDemo.Controllers.Demos.Grid.MasterDetailCrud
{
    public class RestInlController : Controller
    {
        public IActionResult Addresses(int key)
        {
            ViewData["Id"] = key;
            return PartialView();
        }

        private object MapToGridModel(Restaurant o)
        {
            return new { o.Id, o.Name };
        }

        [HttpPost]
        public IActionResult Create(RestaurantInput input)
        {
            if (!ModelState.IsValid)
            {
                return Json(ModelState.GetErrorsInline());
            }

            var ent = Db.Insert(new Restaurant
            {
                Name = input.Name,
                IsCreated = true
            });

            return Json(new { Item = MapToGridModel(ent) });

        }

        [HttpPost]
        public IActionResult Edit(RestaurantInput input)
        {
            if (!ModelState.IsValid)
            {
                return Json(ModelState.GetErrorsInline());
            }

            var ent = Db.Get<Restaurant>(input.Id);
            ent.Name = input.Name;
            Db.Update(ent);

            return Json(new { });
        }
    }
}