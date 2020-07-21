using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;

using AweCoreDemo.Models;
using AweCoreDemo.Utils;
using AweCoreDemo.ViewModels.Display;
using Omu.Awem.Helpers;
using Omu.AwesomeMvc;
using System.Text.Json;
 
namespace AweCoreDemo.Controllers.Awesome
{
    public class DataController : Controller
    {
        /*begin*/
        public IActionResult GetCategories()
        {
            return Json(Db.Categories.Select(o => new KeyContent(o.Id, o.Name)));
        }

        public IActionResult GetMeals(int[] categories)
        {
            categories = categories ?? new int[] { };
            var items = Db.Meals.Where(o => categories.Contains(o.Category.Id))
                .Select(o => new KeyContent(o.Id, o.Name));

            return Json(items);
        }
        /*end*/

        public IActionResult GetAllMeals()
        {
            var items = Db.Meals.Select(o => new KeyContent(o.Id, o.Name));
            return Json(items);
        }

        public IActionResult GetChefs()
        {
            var items = Db.Chefs.Select(o => new KeyContent(o.Id, o.FirstName + " " + o.LastName));
            return Json(items);
        }

        /*beginamg*/
        public IActionResult GetAllMealsGrouped()
        {
            var res = new List<Oitem>();
            var groups = Db.Meals.GroupBy(o => o.Category);
            foreach (var g in groups)
            {
                res.Add(new Oitem
                {
                    Content = g.Key.Name,
                    Class = "o-itm o-itmg",
                    NonVal = true,
                    Items = g.Select(meal => new Oitem(meal.Id, meal.Name)),
                });
            }

            return Json(res);
        }
        /*endamg*/

        /*begintree*/
        public IActionResult GetTreeNodesLazy(int? key)
        {
            // key has value, lazy request
            var nodes = key.HasValue ?
                buildItemTrees(Db.TreeNodes.Where(o => o.Id == key)).Take(10) :

                // initial load, return roots (parent is null)
                buildItemTrees(Db.TreeNodes.Where(o => o.Parent == null).Take(10), setLazyChild: true);

            return Json(nodes);
        }

        /// <summary>
        /// builds oitem tree collection from treeNodes collection 
        /// </summary>
        private IEnumerable<Oitem> buildItemTrees(IEnumerable<TreeNode> nodes, int lvl = 0, bool setLazyChild = false)
        {
            var list = new List<Oitem>();
            foreach (var node in nodes)
            {
                var oitem = new Oitem { Key = node.Id.ToString(), Content = node.Name };
                list.Add(oitem);
                var children = Db.TreeNodes.Where(o => o.Parent == node);

                if (!children.Any()) continue;

                // set node as lazy after lvl 0
                if (setLazyChild && lvl > 0)
                {
                    oitem.Lazy = true;
                }
                else
                {
                    oitem.Items = buildItemTrees(children, lvl + 1, setLazyChild);
                }
            }

            return list;
        }

        public IActionResult SearchTree(string term)
        {
            term = (term ?? string.Empty).ToLower();
            var result = Db.TreeNodes.Where(o => o.Name.ToLower().Contains(term)).Take(1).ToList();
            var roots = new List<TreeNode>();

            foreach (var treeNode in result)
            {
                roots.Add(getRoot(treeNode));
            }

            roots = roots.Distinct().ToList();

            var nodes = buildItemTrees(roots);
            return Json(nodes);
        }

        private TreeNode getRoot(TreeNode node)
        {
            return node.Parent == null ? node : getRoot(node.Parent);
        }
        /*endtree*/

        /*beginrso*/
        public IActionResult GetMealsInit(int? v)
        {
            var items = Db.Meals.Take(3).ToList();
            var selected = Db.Meals.SingleOrDefault(o => o.Id == v);

            if (selected != null && !items.Contains(selected))
            {
                items.Add(selected);
            }

            return Json(items.Select(o => new KeyContent(o.Id, o.Name)));
        }

        public IActionResult SearchMeals(string term = "")
        {
            var items = Db.Meals
                .Where(o => o.Name.IndexOf(term, StringComparison.OrdinalIgnoreCase) >= 0)
                .Take(10)
                .Select(o => new KeyContent(o.Id, o.Name));

            return Json(items);
        }
        /*endrso*/

        /*beginimg*/
        public IActionResult GetMealsImg()
        {
            var url = Url.Content(DemoUtils.MealsUrl);
            var items = Db.Meals
                .Select(o => new MealDisplay(o.Id, o.Name, url + o.Name + ".jpg"));
            return Json(items);
        }
        /*endimg*/

        /*beginaimg*/
        public IActionResult GetMealsImgAutoc(string v)
        {
            v = (v ?? string.Empty).ToLower();
            var url = Url.Content(DemoUtils.MealsUrl);
            var items = Db.Meals
                .Where(o => o.Name.ToLower().Contains(v))
                .Select(o => new MealDisplay(o.Id, o.Name, url + o.Name + ".jpg"));

            return Json(items);
        }
        /*endaimg*/

        public IActionResult GetMealsGroupedImg()
        {
            var url = Url.Content(DemoUtils.MealsUrl);

            var res = new List<MealOitem>();
            var groups = Db.Meals.GroupBy(o => o.Category);
            foreach (var g in groups)
            {
                res.Add(new MealOitem
                {
                    Content = g.Key.Name,
                    Class = "o-itm o-itmg",
                    NonVal = true,
                    Items = g.Select(meal => new MealOitem { Key = meal.Id, Content = meal.Name, url = url + meal.Name + ".jpg" })
                });
            }

            return Json(res);
        }

        public IActionResult GetCountries()
        {
            var items = new List<KeyContent> { new KeyContent(string.Empty, "any country") };
            items.AddRange(Db.Countries.Select(o => new KeyContent(o.Id, o.Name)));

            return Json(items);
        }

        /*begingmsv*/
        public IActionResult GetMealsSetValue(int[] categories)
        {
            categories = categories ?? new int[] { };

            var items = Db.Meals.Where(o => categories.Contains(o.Category.Id)).ToList();

            object value = null;
            if (items.Any())
            {
                value = new[] { items.Skip(1).First().Id };
            }

            return Json(new AweItems
            {
                Items = items.Select(o => new KeyContent(o.Id, o.Name)),
                Value = value
            });
        }
        /*endgmsv*/

        /*beginsv*/
        public IActionResult GetMealsSetValue2(int[] categories)
        {
            categories = categories ?? new int[] { };

            var items = Db.Meals.Where(o => categories.Contains(o.Category.Id)).ToList();

            object value = null;
            if (items.Any())
            {
                value = items.Skip(1).First().Id;
            }

            return Json(new AweItems
            {
                Items = items.Select(o => new KeyContent(o.Id, o.Name)),
                Value = value
            });
        }

        public IActionResult GetOrgSetValue()
        {
            var items = Db.Organisations.ToList();

            object value = null;
            if (items.Any())
            {
                value = items.Skip(2).First().Id;
            }

            return Json(new AweItems
            {
                Items = items.Select(o => new KeyContent(o.Id, o.Name)),
                Value = value
            });
        }
        /*endsv*/

        /*beginmlc*/
        public IActionResult GetNumbers(int[] parent)
        {
            parent = parent ?? new int[] { };

            var items = new[] { 3, 7, 10 };

            return Json(items.Select(o => o + parent.Sum()).Select(o => new KeyContent(o, o.ToString(CultureInfo.InvariantCulture))));
        }

        public IActionResult GetWords(string parent)
        {
            var items = new[] { "The", "brown", "cow", "is eating", "green", "grass" };

            return Json(items.Select(o => parent + " " + o).Select(o => new KeyContent(o, o)));
        }
        /*endmlc*/

        public IActionResult GetCategoriesFirstOption()
        {
            var list = new List<KeyContent> { new KeyContent("", "please select") };
            list.AddRange(Db.Categories.Select(o => new KeyContent(o.Id, o.Name)));
            return Json(list);
        }

        public IActionResult GetMealsList()
        {
            return Json(Db.Meals);
        }

        public IActionResult MealsGrid(GridParams g, string name)
        {
            name = (name ?? string.Empty).ToLower();
            var query = Db.Meals.Where(o => o.Name.ToLower().Contains(name)).AsQueryable();
            // there's no need to call tolower when using a real db

            return Json(new GridModelBuilder<Meal>(query, g) { Key = "Id" }.Build());
        }

        public IActionResult MealsGridSearch(GridParams g, int[] selected, string name)
        {
            name = (name ?? string.Empty).ToLower();
            selected = selected ?? new int[] { };

            var query = Db.Meals.Where(o => o.Name.ToLower().Contains(name) && !selected.Contains(o.Id)).AsQueryable();
            // there's no need to call tolower when using a real db

            return Json(new GridModelBuilder<Meal>(query, g) { Key = "Id" }.Build());
        }

        public IActionResult MealsGridSelected(GridParams g, int[] selected)
        {
            var sel = (selected ?? new int[] { }).ToList();
            var items = Db.Meals.Where(o => sel.Contains(o.Id)).ToList()
                                .OrderBy(o => sel.IndexOf(o.Id));

            return Json(new GridModelBuilder<Meal>(items.AsQueryable(), g) { Key = "Id", DefaultKeySort = Sort.None }.Build());
        }

        public IActionResult GetDinnerItem(int? v)
        {
            Check.NotNull(v, "v");

            var o = Db.Dinners.Single(f => f.Id == v);

            return Json(new KeyContent(o.Id, o.Name));
        }

        public IActionResult GetDinnerItems(int[] v)
        {
            v = v ?? new int[] { };
            return Json(Db.Dinners.Where(o => v.Contains(o.Id))
                .Select(o => new KeyContent(o.Id, o.Name)));
        }

        public IActionResult GetMenuNodes()
        {
            var menuNodes =
                MySiteMap.GetAll().Select(
                    o =>
                    new
                    {
                        o.Id,
                        o.Name,
                        o.Keywords,
                        ParentId = o.Parent?.Id ?? 0,
                        Url = o.Action != null ? Url.Action(o.Action, o.Controller) + o.Anchor : null,
                        o.Action,
                        o.Controller,
                        o.Collapsed,
                        o.NoMenu,
                        o.Anchor
                    });

            return Json(menuNodes, new JsonSerializerOptions());
        }

        public IActionResult LunchGrid(GridParams g)
        {
            var list = Db.Lunches.AsQueryable();

            return Json(new GridModelBuilder<Lunch>(list, g)
            {
                Key = "Id", // needed for Entity Framework | nesting | tree | api
                Map = o => new
                {
                    o.Id,
                    o.Person,
                    o.Food,
                    o.Location,
                    o.Price,
                    Date = o.Date.ToShortDateString(),
                    CountryName = o.Country.Name,
                    ChefFName = o.Chef.FirstName,
                    ChefLName = o.Chef.LastName
                }
            }.Build());
        }

        public IActionResult LunchGridFilter(
            GridParams g, 
            string person, 
            string food, 
            string location, 
            int? country,
            int? chef,
            DateTime? date)
        {
            food = (food ?? "").ToLower();
            person = (person ?? "").ToLower();
            location = (location ?? "").ToLower();

            var list = Db.Lunches
                .Where(o => o.Food.ToLower().Contains(food) 
                && o.Person.ToLower().Contains(person)
                && o.Location.ToLower().Contains(location))
                .AsQueryable();

            if (country.HasValue) list = list.Where(o => o.Country.Id == country);
            if (chef.HasValue) list = list.Where(o => o.Chef.Id == chef);
            if (date.HasValue) list = list.Where(o => o.Date == date);

            return Json(new GridModelBuilder<Lunch>(list, g)
            {
                KeyProp = o => o.Id,// needed for Entity Framework | nesting | tree | api
                Map = o => new
                {
                    o.Id,
                    o.Person,
                    o.Food,
                    o.FoodPic,
                    o.Location,
                    o.Price,
                    Date = o.Date.ToShortDateString(),
                    CountryName = o.Country.Name,
                    ChefName = o.Chef.FirstName + " " + o.Chef.LastName
                }
            }.Build());
        }

        public IActionResult ApiGetMeals(int? v, bool? cat1)
        {
            var items = Db.Meals;

            if (cat1.HasValue && cat1.Value)
            {
                items = items.Where(o => o.Category == Db.Categories[0]).ToList();
            }

            return Json(items.Select(o => new KeyContent(o.Id, o.Name)));
        }

        public IActionResult LunchesUi(GridParams g, string search)
        {
            search = (search ?? "").ToLower();

            var query = Db.Lunches
                .Where(o => o.Food.ToLower().Contains(search) ||
                            o.Person.ToLower().Contains(search) ||
                            o.Chef.FirstName.ToLower().Contains(search) ||
                            o.Chef.LastName.ToLower().Contains(search) ||
                            o.Location.ToLower().Contains(search) ||
                            o.Country.Name.ToLower().Contains(search))
                .AsQueryable();

            var dict = new Dictionary<string, string>
            {
                {"CountryName", "Country.Name"},
                {"ChefName", "Chef.FirstName,Chef.LastName"}
            };

            // map back the column.bind values, or gmb will throw (Lunch has no CountryName prop)
            unmap(g, dict);

            var gmb = new GridModelBuilder<Lunch>(g)
            {
                KeyProp = o => o.Id
            };

            Func<Lunch, object> map = o => new
            {
                o.Id,
                o.Person,
                o.Food,
                o.FoodPic,
                o.Location,
                o.Price,
                Date = o.Date.ToShortDateString(),
                CountryName = o.Country.Name,
                ChefName = o.Chef.FirstName + " " + o.Chef.LastName
            };

            query = gmb.OrderBy(query);

            var count = query.Count();
            var items = gmb.GetPage(query).Select(map); // mapping to send only the needed data

            return Json(new { count, items });
        }

        private GridParams unmap(GridParams g, IDictionary<string, string> dict)
        {
            if (g.SortNames != null)
            {
                g.SortNames = g.SortNames.Select(sn => dict.ContainsKey(sn) ? dict[sn] : sn).ToArray();
            }

            return g;
        }

        /*begincasg*/
        public IActionResult CategoriesGrid(GridParams g)
        {
            return Json(new GridModelBuilder<Category>(Db.Categories.AsQueryable(), g)
            {
                Key = "Id"
            }.Build());
        }

        public IActionResult ChildMealsGrid(GridParams g, int[] categories)
        {
            categories = categories ?? new int[] { };

            return Json(new GridModelBuilder<Meal>(Db.Meals
                .Where(o => categories.Contains(o.Category.Id)).AsQueryable(), g).Build());
        }
        /*endcasg*/

        public IActionResult GetLunches()
        {
            return Json(Db.Lunches.Take(200).Select(o => new
            {
                o.Id,
                o.Person,
                o.Food,
                o.Location,
                CountryName = o.Country.Name,
                ChefName = o.Chef.FirstName + " " + o.Chef.LastName,
                o.Date,
                DateStr = o.Date.ToShortDateString()
            }));
        }

        /*beginenum*/
        public IActionResult GetWeatherEnumItems()
        {
            var type = typeof(WeatherType);
            var items = Enum.GetValues(type).Cast<int>().Select(o => new KeyContent(o, SplitByCapLetter(Enum.GetName(type, o)))).ToList();

            // remove if not needed or if used with odropdown/ajaxradiolist
            items.Insert(0, new KeyContent(string.Empty, "please select"));

            return Json(items);
        }

        /// <summary>
        /// from HiThere to Hi There
        /// </summary>
        private string SplitByCapLetter(string s)
        {
            var r = new Regex(@"
                (?<=[A-Z])(?=[A-Z][a-z]) |
                 (?<=[^A-Z])(?=[A-Z]) |
                 (?<=[A-Za-z])(?=[^A-Za-z])", RegexOptions.IgnorePatternWhitespace);

            return r.Replace(s, " ");
        }
        /*endenum*/

        public IActionResult Rend(int v)
        {
            var views = new[]
            {
                "GridInlineProcedure",
                //"GridInlineStock"//,
               // "GridCrud",
                //"CardsAndItems",
                //"DropmenuItems",                
                //"AutocInTxta",
                //"Cascade",
                //"ReorderCardsSplh",
                //"GridCardsView",
                //"GridInlineCrudCustomRender",
                //"LookupCrud"
            };

            if (!Request.IsAjaxRequest()) throw new AwesomeException("ajax only");

            if (views.Length <= v) return Content("end");

            return PartialView("Demos/" + views[v]);
        }
        public IActionResult RendStock(int v)
        {        
            if (!Request.IsAjaxRequest()) throw new AwesomeException("ajax only");
            return PartialView("Demos/" + "GridInlineStock");
        }
        public IActionResult RendStock2(int v)
        {
            if (!Request.IsAjaxRequest()) throw new AwesomeException("ajax only");
            return PartialView("Demos/" + "GridInlineAllocateStock");
        }
        public IActionResult RendStock3(int v)
        {
            if (!Request.IsAjaxRequest()) throw new AwesomeException("ajax only");
            return PartialView("Demos/" + "GridInlineAllocateStock");
        }
    }
}