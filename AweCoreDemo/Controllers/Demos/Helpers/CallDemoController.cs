using Microsoft.AspNetCore.Mvc;

namespace AweCoreDemo.Controllers.Demos.Helpers
{
    public class CallDemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string SayHi()
        {
            return "server says hi";
        }

        public string SayName(string name, int id)
        {
            return "my name is " + name + "; id = " + id;
        }
    }
}