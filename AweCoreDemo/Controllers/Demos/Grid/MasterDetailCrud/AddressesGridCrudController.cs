using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AweCoreDemo.Models;
using AweCoreDemo.ViewModels.Input;
using Omu.AwesomeMvc;
 
namespace AweCoreDemo.Controllers.Demos.Grid.MasterDetailCrud
{
    public class AddressesGridCrudController : Controller
    {
        public IActionResult GridGetItems(GridParams g, int restaurantId)
        {
            var items = Db.RestaurantAddresses.Where(o => o.RestaurantId == restaurantId).AsQueryable();
            var model = new GridModelBuilder<RestaurantAddress>(items, g)
                {
                    Key = "Id",
                    Map = o => new
                    {
                        o.Id,
                        o.Line1,
                        o.Line2,
                        ChefName = o.Chef.FirstName + " " + o.Chef.LastName
                    },
                    GetItem = () => Db.Get<RestaurantAddress>(Convert.ToInt32(g.Key))
                }.Build();
            return Json(model);
        }

        public IActionResult Create(int restaurantId)
        {
            return PartialView(new RestaurantAddressInput { RestaurantId = restaurantId });
        }

        [HttpPost]
        public IActionResult Create(RestaurantAddressInput input)
        {
            if (!ModelState.IsValid)
            {
                return PartialView(input);
            }

            var address = Db.Insert(new RestaurantAddress { Line1 = input.Line1, Line2 = input.Line2, RestaurantId = input.RestaurantId });

            return Json(address); // use MapToGridModel like in Grid Crud Demo when grid uses Map
        }

        public IActionResult Edit(int id)
        {
            var address = Db.Get<RestaurantAddress>(id);

            return PartialView(
                "Create",
                new RestaurantAddressInput
                    {
                        Line1 = address.Line1,
                        Line2 = address.Line2,
                        ChefId = address.Chef.Id,
                        RestaurantId = address.RestaurantId
                    });
        }

        [HttpPost]
        public IActionResult Edit(RestaurantAddressInput input)
        {
            if (!ModelState.IsValid)
            {
                return PartialView("Create", input);
            }

            var address = Db.Get<RestaurantAddress>(input.Id);
            address.Line1 = input.Line1;
            address.Line2 = input.Line2;
            address.Chef = Db.Get<Chef>(input.ChefId);

            return Json(new { input.Id });
        }

        public IActionResult Delete(int id)
        {
            var address = Db.Get<RestaurantAddress>(id);

            return PartialView(new DeleteConfirmInput
                {
                    Id = id,
                    Type = "restaurant address",
                    Name = address.Line1 + " "+ address.Line2
                });
        }

        [HttpPost]
        public IActionResult Delete(DeleteConfirmInput input)
        {
            Db.Delete<RestaurantAddress>(input.Id);
            return Json(new { input.Id });
        }
    }
}