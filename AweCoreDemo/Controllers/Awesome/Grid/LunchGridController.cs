using System.Linq;
using Microsoft.AspNetCore.Mvc;

using AweCoreDemo.Models;

using Omu.AwesomeMvc;
 
namespace AweCoreDemo.Controllers.Awesome.Grid
{
    public class LunchGridController : Controller
    {
        public IActionResult GetItems(GridParams g, string person, string food, int? country)
        {
            food = (food ?? "").ToLower();
            person = (person ?? "").ToLower();
            
            var list = Db.Lunches
                .Where(o => o.Food.ToLower().Contains(food) && o.Person.ToLower().Contains(person))
                .AsQueryable();

            if (country.HasValue) list = list.Where(o => o.Country.Id == country);
            
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
    }
}