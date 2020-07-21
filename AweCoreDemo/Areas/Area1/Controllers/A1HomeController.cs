using Microsoft.AspNetCore.Mvc;
using Omu.AwesomeMvc;
 
namespace AweCoreDemo.Areas.Area1.Controllers
{
    public class A1HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string name)
        {
            ViewData["result"] = name;
            return View();
        }
        
        public IActionResult GetPart()
        {
            return Content(this.RenderPartialView("AreaPart", new { Number = 1 }));
        }
    }
}