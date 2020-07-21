using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;
using AweCoreDemo.Hubs;

namespace AweCoreDemo.Controllers
{
    public class HomeController : Controller
    {
        //void SendMessage(string message)
        //{
        //    GlobalHost
        //   .ConnectionManager
        //   .GetHubContext<SyncHub>().Clients.sendMessage(
        // message);
        //}
        readonly private IHubContext<SyncHub> _hubContext;
        public HomeController(IHubContext<SyncHub> hubcontext)
        {
            _hubContext = hubcontext;
        }
        public IActionResult Index()
        {
            return View();
        }
        public RedirectToPageResult GetInlineViewDemo()
        {
            return RedirectToPage("./Consultations/InlineEdit");//View("/Views/Home/Index.cshtml");
        }
        public RedirectToRouteResult RedirectToExamPage(int id)
        {
           return RedirectToRoute("/Lab/Examinations/Edit", new { id });
            //return RedirectToPage("./Lab/Examinations/Edit/"+id);//View("/Views/Home/Index.cshtml");
        }
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Test()
        {
            return View();
        }

        public IActionResult Ptest()
        {
            return View();
        }

        public IActionResult Social()
        {
            return PartialView();
        }
    }
}