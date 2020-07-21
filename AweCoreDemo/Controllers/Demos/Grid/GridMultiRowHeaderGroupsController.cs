using System.Linq;
using Microsoft.AspNetCore.Mvc;

using AweCoreDemo.Models;

using Omu.AwesomeMvc;
 
namespace AweCoreDemo.Controllers.Demos.Grid
{
    public class GridMultiRowHeaderGroupsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}