using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using AweCoreDemo.Models;

using Omu.AwesomeMvc;
 
namespace AweCoreDemo.Controllers.Demos.Grid
{
    /*begin*/
    public class GridNoRecordsFoundCustomLoadingDemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GridGetItems(GridParams g, string person, string food)
        {
            food = (food ?? "").ToLower();
            person = (person ?? "").ToLower();
            
            Task.Delay(2000).Wait();
            var list = Db.Lunches
                .Where(o => o.Food.ToLower().Contains(food) && o.Person.ToLower().Contains(person))
                .AsQueryable();

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
                    ChefName = o.Chef.FirstName + " " + o.Chef.LastName
                }
            }.Build());
        }
    }
    /*end*/
}