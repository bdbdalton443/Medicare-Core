using Microsoft.AspNetCore.Mvc;

namespace AweCoreDemo.Areas.Area1.Controllers
{
    [Area("Area1")]
    public class HomesController : Controller
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
    }
}