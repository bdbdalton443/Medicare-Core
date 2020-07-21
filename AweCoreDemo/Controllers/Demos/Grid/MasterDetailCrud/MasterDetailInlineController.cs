using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AweCoreDemo.Models;
using AweCoreDemo.ViewModels.Input;
using Omu.Awem.Utils;
using Omu.AwesomeMvc;
 
namespace AweCoreDemo.Controllers.Demos.Grid.MasterDetailCrud
{
    public class MasterDetailInlineController : Controller
    {
        private object MapAddr(RestaurantAddress o)
        {
            return new
            {
                o.Id,
                o.Line1,
                o.Line2,
                ChefName = o.Chef.FirstName + " " + o.Chef.LastName,

                // for inline editing
                ChefId = o.Chef.Id
            };
        }

        public IActionResult Create()
        {
            // needed so we could add addresses even before the restaurant is created/saved
            var rest = Db.Insert(new Restaurant());

            return PartialView(new RestaurantInput { Id = rest.Id });
        }

        [HttpPost]
        public IActionResult Create(RestaurantInput input)
        {
            if (!ModelState.IsValid)
            {
                return PartialView(input);
            }

            var restaurant = Db.Get<Restaurant>(input.Id);
            restaurant.Name = input.Name;
            restaurant.IsCreated = true;

            return Json(restaurant); // use MapToGridModel like in Grid Crud Demo when grid uses Map
        }

        public IActionResult Edit(int id)
        {
            var rest = Db.Get<Restaurant>(id);
            return PartialView("Create", new RestaurantInput { Id = id, Name = rest.Name });
        }

        [HttpPost]
        public IActionResult Edit(RestaurantInput input)
        {
            if (!ModelState.IsValid)
            {
                return PartialView("Create", input);
            }

            var rest = Db.Get<Restaurant>(Convert.ToInt32(input.Id));

            rest.Name = input.Name;

            return Json(new { rest.Id });
        }

        public IActionResult Delete(int id, string gridId)
        {
            var restaurant = Db.Get<Restaurant>(id);

            return PartialView(new DeleteConfirmInput
            {
                Id = id,
                Type = "restaurant",
                Name = restaurant.Name
            });
        }

        [HttpPost]
        public IActionResult Delete(DeleteConfirmInput input)
        {
            Db.Delete<Restaurant>(input.Id);
            return Json(new { input.Id });
        }

        public IActionResult AddressGrid(GridParams g, int restaurantId)
        {
            var items = Db.RestaurantAddresses.Where(o => o.RestaurantId == restaurantId).AsQueryable();
            var model = new GridModelBuilder<RestaurantAddress>(items, g)
            {
                Key = "Id",
                Map = MapAddr,
                GetItem = () => Db.Get<RestaurantAddress>(Convert.ToInt32(g.Key))
            }.Build();
            return Json(model);
        }

        [HttpPost]
        public IActionResult CreateAddr(RestaurantAddressInput input)
        {
            if (!ModelState.IsValid) return Json(ModelState.GetErrorsInline());

            var ent = new RestaurantAddress
            {
                Line1 = input.Line1,
                Line2 = input.Line2,
                Chef = Db.Get<Chef>(input.ChefId)
            };

            Db.Insert(ent);

            return Json(new { Item = MapAddr(ent) });
        }

        [HttpPost]
        public IActionResult EditAddr(RestaurantAddressInput input)
        {
            if (!ModelState.IsValid) return Json(ModelState.GetErrorsInline());

            var ent = Db.Get<RestaurantAddress>(input.Id);
            ent.Line1 = input.Line1;
            ent.Line2 = input.Line2;
            ent.Chef = Db.Get<Chef>(input.ChefId);

            Db.Update(ent);

            return Json(new { });
        }
    }
}