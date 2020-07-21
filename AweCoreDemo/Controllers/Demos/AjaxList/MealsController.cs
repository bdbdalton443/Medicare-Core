using Microsoft.AspNetCore.Mvc;

namespace AweCoreDemo.Controllers.Demos.AjaxList
{
    public class MealsController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToActionPermanent("Index", "Dinners");
        }
    }
}