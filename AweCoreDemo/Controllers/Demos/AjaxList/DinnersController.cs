using Microsoft.AspNetCore.Mvc;

namespace AweCoreDemo.Controllers.Demos.AjaxList
{
    public class DinnersController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToActionPermanent("Crud","AjaxListDemo");
        }
    }
}