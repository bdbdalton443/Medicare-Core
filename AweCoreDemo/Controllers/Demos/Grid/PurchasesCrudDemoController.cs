using Microsoft.AspNetCore.Mvc;

namespace AweCoreDemo.Controllers.Demos.Grid
{
    public class PurchasesCrudDemoController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToActionPermanent("Index", "GridCrudDemo");
        }
    }
}