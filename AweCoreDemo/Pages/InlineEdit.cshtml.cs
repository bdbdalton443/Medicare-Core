using System;
using System.Linq;
using AweCoreDemo.Models;
using AweCoreDemo.ViewModels.Input;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Omu.Awem.Utils;
using Omu.AwesomeMvc;

namespace AweRazorPages.Pages
{
    public class InlineEditModel : PageModel
    {
        public IActionResult OnPostGetCategories()
        {
            var items = Db.Categories
                .Select(o => new KeyContent(o.Id, o.Name));

            return new JsonResult(items);
        }

        private object MapToGridModel(Dinner o)
        {
            return new
            {
                o.Id,
                o.Name,
                Date = o.Date.ToShortDateString(),
                ChefName = o.Chef.FirstName + " " + o.Chef.LastName,
                Meals = string.Join(", ", o.Meals.Select(m => m.Name)),
                BonusMeal = o.BonusMeal.Name,
                o.Organic,
                DispOrganic = o.Organic ? "Yes" : "No",

                // below properties used for inline editing only
                MealsIds = o.Meals.Select(m => m.Id).ToArray(),
                ChefId = o.Chef.Id,
                BonusMealId = o.BonusMeal.Id
            };
        }

        public IActionResult OnPostGridGetItems(GridParams g, string search)
        {
            search = (search ?? "").ToLower();
            var items = Db.Dinners.Where(o => o.Name.ToLower().Contains(search)).AsQueryable();
        
            var model = new GridModelBuilder<Dinner>(items, g)
            {
                Key = "Id", // needed for api select, update, tree, nesting, EF
                GetItem = () => Db.Get<Dinner>(Convert.ToInt32(g.Key)), // called by the grid.api.update
                Map = MapToGridModel,
            }.Build();

            return new JsonResult(model);
        }

        public IActionResult OnPostCreate(DinnerInput input)
        {
            if (ModelState.IsValid)
            {
                var dinner = new Dinner
                {
                    Name = input.Name,
                    Date = input.Date.Value,
                    Chef = Db.Get<Chef>(input.Chef),
                    Meals = input.Meals.Select(mid => Db.Get<Meal>(mid)),
                    BonusMeal = Db.Get<Meal>(input.BonusMealId),
                    Organic = input.Organic ?? false
                };

                Db.Insert(dinner);

                return new JsonResult(new { Item = MapToGridModel(dinner) });
            }

            return new JsonResult(ModelState.GetErrorsInline());
        }

        public IActionResult OnPostEdit(DinnerInput input)
        {
            if (ModelState.IsValid)
            {
                var dinner = Db.Get<Dinner>(input.Id);
                dinner.Name = input.Name;
                dinner.Date = input.Date.Value;
                dinner.Chef = Db.Get<Chef>(input.Chef);

                dinner.Meals = input.Meals.Select(mid => Db.Get<Meal>(mid));

                dinner.BonusMeal = Db.Get<Meal>(input.BonusMealId);
                dinner.Organic = input.Organic ?? false;
                Db.Update(dinner);

                return new JsonResult(new { });
            }

            return new JsonResult(ModelState.GetErrorsInline());
        }

        public IActionResult OnGetDelete(int id)
        {
            var dinner = Db.Get<Dinner>(id);

            return Partial("Delete", new DeleteConfirmInput
            {
                Id = id,
                Type = "dinner",
                Name = dinner.Name
            });
        }

        public IActionResult OnPostDelete(DeleteConfirmInput input)
        {
            Db.Delete<Dinner>(input.Id);

            // the PopupForm's success function utils.itemDeleted expects an obj with "Id" property
            return new JsonResult(new { input.Id });
        }
    }
}