using Microsoft.AspNetCore.Mvc;

using Omu.AwesomeMvc;
 
namespace AweCoreDemo.Controllers.Awesome.AjaxDropdown
{
    public class SortAjaxDropdownController : Controller
    {
        public IActionResult GetItems()
        {
            var options = new[]
                              {
                                  new KeyContent(Sort.None, "None"),
                                  new KeyContent(Sort.Asc, "Asc"),
                                  new KeyContent(Sort.Desc, "Desc")
                              };
            return Json(options);
        }
    }
}