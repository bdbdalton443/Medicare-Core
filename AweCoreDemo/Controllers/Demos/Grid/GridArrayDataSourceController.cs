using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

using AweCoreDemo.ViewModels;

using Omu.AwesomeMvc;
 
namespace AweCoreDemo.Controllers.Demos.Grid
{
    public class GridArrayDataSourceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GridGetItems(GridParams g)
        {
            var data = new[]
                {
                    new[] { "Id", "Name", "Meal" }, 
                    new[] { "1", "Vincenzo", "Pizza" }, 
                    new[] { "2", "Ella", "French toast" }, 
                    new[] { "3", "Zazzles", "Pizza" }, 
                    new[] { "4", "Evan", "Banana" }
                };

            var columns = new List<Column>();
            columns.Add(new Column { Header = "Id", ClientFormat = ".Id", Width = 100});

            for (var i = 1; i < data[0].Length; i++)
            {
                columns.Add(new Column{ Header = data[0][i], ClientFormatFunc = "getVal("+i+")" });
            }

            var items = new List<GridArrayRow>();
            for (var i = 1; i < data.Length; i++)
            {
                items.Add(new GridArrayRow{ Id = data[i][0], Values = data[i]});
            }

            g.Columns = columns.ToArray();

            var model = new GridModelBuilder<GridArrayRow>(items.AsQueryable(), g).Build();
            return Json(model);
        }
    }
}