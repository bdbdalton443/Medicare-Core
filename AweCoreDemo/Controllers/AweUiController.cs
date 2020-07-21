using Microsoft.AspNetCore.Mvc;

namespace AweCoreDemo.Controllers
{
    public class AweUiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}