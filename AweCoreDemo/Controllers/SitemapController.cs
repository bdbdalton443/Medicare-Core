using Microsoft.AspNetCore.Mvc;

namespace AweCoreDemo.Controllers
{
    public class SitemapController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}