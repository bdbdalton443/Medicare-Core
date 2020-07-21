using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AweCoreDemo.Models;
using AweCoreDemo.ViewModels.Input;
using Omu.AwesomeMvc;
 
namespace AweCoreDemo.Controllers.Demos.Grid.MasterDetailCrud
{
    public class MasterDetailCrudDemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RestaurantGridGetItems(GridParams g)
        {
            var model = new GridModelBuilder<Restaurant>(Db.Restaurants.Where(o => o.IsCreated).AsQueryable(), g)
            {
                Key = "Id",
                GetItem = () => Db.Get<Restaurant>(Convert.ToInt32(g.Key))
            }.Build();
            return Json(model);
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
    }
}