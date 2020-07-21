using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AweCoreDemo.Models;
using AweCoreDemo.ViewModels.Input;
using Omu.Awem.Utils;
using Omu.AwesomeMvc;
 
namespace AweCoreDemo.Controllers.Demos.Grid
{
    public class GridInlineEditParentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private object MapToGridModel(ParentMeal o)
        {
            return new
            {
                o.Id,

                // for display
                CategoryName = o.Category.Name,
                MealName = o.Meal.Name,

                // for inline editing helpers to get value
                CategoryId = o.Category.Id,
                MealId = o.Meal.Id
            };
        }

        public IActionResult GridGetItems(GridParams g)
        {
            var items = Db.ParentMeals.AsQueryable();

            var model = new GridModelBuilder<ParentMeal>(items, g)
            {
                KeyProp = o => o.Id,
                GetItem = () => Db.Get<ParentMeal>(Convert.ToInt32(g.Key)),
                Map = MapToGridModel,
            }.Build();

            return Json(model);
        }

        [HttpPost]
        public IActionResult Create(ParentMealInput input)
        {
            if (ModelState.IsValid)
            {
                var parentMeal = new ParentMeal
                {
                    Category = Db.Get<Category>(input.CategoryId),
                    Meal = Db.Get<Meal>(input.MealId)
                };

                Db.Insert(parentMeal);

                return Json(new { Item = MapToGridModel(parentMeal) });
            }

            return Json(ModelState.GetErrorsInline());
        }

        [HttpPost]
        public IActionResult Edit(ParentMealInput input)
        {
            if (ModelState.IsValid)
            {
                var parentMeal = Db.Get<ParentMeal>(input.Id);
                parentMeal.Category = Db.Get<Category>(input.CategoryId);
                parentMeal.Meal = Db.Get<Meal>(input.MealId);
                Db.Update(parentMeal);

                return Json(new { });
            }

            return Json(ModelState.GetErrorsInline());
        }

        public IActionResult Delete(int id)
        {
            var parentMeal = Db.Get<ParentMeal>(id);

            return PartialView(new DeleteConfirmInput
            {
                Id = id,
                Name = parentMeal.Meal.Name
            });
        }

        [HttpPost]
        public IActionResult Delete(DeleteConfirmInput input)
        {
            Db.Delete<ParentMeal>(input.Id);
            return Json(new { input.Id });
        }
    }
}