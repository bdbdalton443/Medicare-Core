using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AweCoreDemo.Models;
using AweCoreDemo.Utils;
using Omu.AwesomeMvc;
 
namespace AweCoreDemo.Controllers.Demos.Grid
{
    public class CustomQueryingGridController : Controller
    {
        public IActionResult GetItems(GridParams g)
        {
            var pageSize = g.PageSize;
            var items = Db.Lunches.AsQueryable();

            if (g.SortNames != null)
            {
                IOrderedQueryable<Lunch> orderedItems = null;

                // doing this for demo purposes
                // one might use something like Dynamic Linq 
                // or generate a sql string etc.

                for (int i = 0; i < g.SortNames.Length; i++)
                {
                    var column = g.SortNames[i];
                    var direction = g.SortDirections[i];

                    if (i == 0)
                    {
                        if (column == "Person")
                            orderedItems = direction == "asc"
                                        ? items.OrderBy(o => o.Person)
                                        : items.OrderByDescending(o => o.Person);
                        else if (column == "Food")
                            orderedItems = direction == "asc"
                                        ? items.OrderBy(o => o.Food)
                                        : items.OrderByDescending(o => o.Food);
                    }
                    else
                    {
                        if (column == "Person")
                            orderedItems = direction == "asc"
                                    ? orderedItems.ThenBy(o => o.Person)
                                    : orderedItems.ThenByDescending(o => o.Person);
                        else if (column == "Food")
                            orderedItems = direction == "asc"
                                    ? orderedItems.ThenBy(o => o.Food)
                                    : orderedItems.ThenByDescending(o => o.Food);
                    }
                }

                items = orderedItems;
            }

            var itemsCount = items.Count();
            var pageItems = items.Skip((g.Page - 1) * pageSize).Take(pageSize);

            return Json(new GridModelBuilder<Lunch>(g)
            {
                KeyProp = o => o.Id,
                Map = o => new { o.Id, o.Person, o.Food },
                ItemsCount = itemsCount,
                PageItems = pageItems
            }.Build());
        }

        public async Task<IActionResult> GetEfAsyncItems(GridParams g)
        {
            var items = Db.Lunches.AsQueryable();
            
            var gmb = new GridModelBuilder<Lunch>(g)
            {
                KeyProp = o => o.Id,
                Map = o => new { o.Id, o.Person, o.Food }
            };

            // apply OrderBy according to GridParams
            items = gmb.OrderBy(items);

            // g.Key is set when calling api.update(id)
            if (g.Key != null)
            {
                var item = await Db.GetAsync<Lunch>(Convert.ToInt32(g.Key));
                gmb.GetItem = () => item;
            }
            else
            {
                gmb.ItemsCount = await items.CountAsync();
                gmb.PageItems = await gmb.GetPage(items).ToArrayAsync();
            }

            return Json(gmb.Build());
        }
    }
}