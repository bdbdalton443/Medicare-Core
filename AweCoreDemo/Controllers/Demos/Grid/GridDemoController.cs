using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AweCoreDemo.Models;
using AweCoreDemo.ViewModels.Input;
using Omu.AwesomeMvc;
 
namespace AweCoreDemo.Controllers.Demos.Grid
{
    public class GridDemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Filtering()
        {
            return View();
        }

        public IActionResult Selection()
        {
            return View();
        }

        public IActionResult RTLSupport()
        {
            return View();
        }

        public IActionResult CustomFormat()
        {
            return View();
        }

        public IActionResult CustomQuerying()
        {
            return View();
        }

        public IActionResult ClientSideApi()
        {
            return View();
        }

        public IActionResult Sorting()
        {
            var o = new GridDemoSortingCfgInput
            {
                Sortable = true,
                PageSize = 15,
                PersonSortable = true,
                PersonSort = Sort.Asc,
                PersonRank = 1,
                FoodSortable = true,
                FoodSort = Sort.None,
                FoodRank = 2,
            };
            return View(o);
        }

        public IActionResult SortingContent(GridDemoSortingCfgInput input)
        {
            return PartialView(input);
        }

        public IActionResult Grouping()
        {
            var o = new GridDemoGroupingCfgInput
            {
                Groupable = true,
                ShowGroupedColumn = true,
                ShowGroupBar = true,
                PersonGrouped = true,
                PersonRem = true,
                PersonGroupable = true,
                PersonRank = 1,
                FoodGrouped = false,
                FoodRem = true,
                FoodGroupable = true,
                PageSize = 15
            };

            return View(o);
        }

        public IActionResult GroupingContent(GridDemoGroupingCfgInput input)
        {
            return PartialView(input);
        }

        /*beginformat*/
        public IActionResult CustomFormatGrid(GridParams g)
        {
            return Json(new GridModelBuilder<Lunch>(Db.Lunches.AsQueryable(), g)
            {
                Map = o =>
                {
                    var rowcls = o.Price > 90 ? "pinkb" : o.Price < 30 ? "greenb" : string.Empty;

                    if (o.Date.Year > 2013) rowcls += " date1";

                    return new
                    {
                        o.Id,
                        o.Person,
                        o.Price,
                        o.Food,
                        Date = o.Date.ToString("dd MMMM yyyy"),
                        o.Location,
                        o.Organic,
                        RowClass = rowcls
                    };
                },
                MakeHeader = gr =>
                {
                    var value = AweUtil.GetColumnValue(gr.Column, gr.Items.First()).Single();
                    var strVal = gr.Column == "Date" ? ((DateTime)value).ToString("dd MMMM yyyy") :
                                 gr.Column == "Price" ? value + " GBP" : value.ToString();

                    return new GroupHeader { Content = gr.Header + " - " + strVal };
                }
            }.Build());
        }

        public IActionResult Details(int id)
        {
            var lunch = Db.Get<Lunch>(id);

            return PartialView(lunch);
        }

        public IActionResult OpenDetails(int id)
        {
            var lunch = Db.Get<Lunch>(id);

            return View(lunch);
        }
        /*endformat*/
    }
}