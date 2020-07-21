using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Omu.AwesomeMvc;
using AweCoreDemo.Models;

namespace AweRazorPages.Pages
{
    public class Page1Model : PageModel
    {
        public IActionResult OnPostGetCategories()
        {
            var items = Db.Categories
                .Select(o => new KeyContent(o.Id, o.Name));

            return new JsonResult(items);
        }

        public IActionResult OnPostGetMeals(int? parent)
        {
            var items = Db.Meals.Where(o => o.Category.Id == parent)
                .Select(o => new KeyContent(o.Id, o.Name));

            return new JsonResult(items);
        }

        public IActionResult OnPostGetAllMeals()
        {
            var items = Db.Meals.Select(o => new KeyContent(o.Id, o.Name));

            return new JsonResult(items);
        }

        public IActionResult OnPostGetMealsAuto(string v)
        {
            v = (v ?? "").ToLower().Trim();
            var items = Db.Meals.Where(o => o.Name.ToLower().Contains(v))
                .Take(5)
                .Select(o => new KeyContent(o.Id, o.Name));

            return new JsonResult(items);
        }

        public IActionResult OnPostGridGetItems(GridParams g)
        {
            var list = Db.Dinners.AsQueryable();

            var gridModel = new GridModelBuilder<Dinner>(list, g)
            {
                Key = "Id", // needed when using EF, nesting, tree, client api
                Map = o => new
                {
                    o.Id,
                    o.Name,
                    Date = o.Date.ToString("dd MMM yyyy"),
                    CountryName = o.Country.Name,
                    ChefName = o.Chef.FirstName + " " + o.Chef.LastName
                }
            }.Build();

            return new JsonResult(gridModel);
        }

        public IActionResult OnPostGetMealsAjaxList(string parent, int page)
        {
            const int PageSize = 10;
            parent ??= "";

            var list = Db.Meals.Where(o => o.Name.ToLower().Contains(parent.ToLower())).OrderByDescending(o => o.Id);

            return new JsonResult(new AjaxListResult
            {
                Items = list.Skip((page - 1) * PageSize).Take(PageSize).Select(o => new KeyContent(o.Id, o.Name)),
                More = list.Count() > page * PageSize
            });
        }
    }
}