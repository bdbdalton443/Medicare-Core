using Microsoft.AspNetCore.Mvc;
using AweCoreDemo.Models;
using AweCoreDemo.ViewModels.Input;
using Omu.Awem.Utils;

namespace AweCoreDemo.Controllers.Demos.Grid.MasterDetailCrud
{
    public class AddrInlGridController : Controller
    {
        private object MapToGridModel(RestaurantAddress o)
        {
            return new { o.Id, o.Line1, o.Line2 };
        }

        [HttpPost]
        public IActionResult Create(RestaurantAddressInput input)
        {
            if (!ModelState.IsValid)
            {
                return Json(ModelState.GetErrorsInline());
            }

            var ent = Db.Insert(new RestaurantAddress
            {
                RestaurantId = input.RestaurantId,
                Line1 = input.Line1,
                Line2 = input.Line2,
                Chef = Db.Get<Chef>(input.ChefId)
            });

            return Json(new { Item = MapToGridModel(ent) });

        }

        [HttpPost]
        public IActionResult Edit(RestaurantAddressInput input)
        {
            if (!ModelState.IsValid)
            {
                return Json(ModelState.GetErrorsInline());
            }

            var ent = Db.Get<RestaurantAddress>(input.Id);
            ent.Line1 = input.Line1;
            ent.Line2 = input.Line2;
            ent.Chef = Db.Get<Chef>(input.ChefId);

            Db.Update(ent);

            return Json(new { });
        }
    }
}