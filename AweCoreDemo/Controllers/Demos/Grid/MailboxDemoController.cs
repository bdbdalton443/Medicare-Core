using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

using AweCoreDemo.Models;

namespace AweCoreDemo.Controllers.Demos.Grid
{
    public class MailboxDemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Delete(IEnumerable<int> ids)
        {
            foreach (var id in ids)
            {
                Db.Delete<Message>(id);    
            }
            return Json(new { });
        }

        public IActionResult ReadMessage(int id)
        {
            var msg = Db.Get<Message>(id);
            msg.IsRead = true;
            Db.Update(msg);

            return PartialView(msg);
        }

        [HttpPost]
        public IActionResult MarkRead(int[] ids)
        {
            foreach (var id in ids)
            {
                var msg = Db.Get<Message>(id);
                msg.IsRead = true;
                Db.Update(msg);
            }

            return Json(new { });
        }

        [HttpPost]
        public IActionResult MarkUnread(int[] ids)
        {
            foreach (var id in ids)
            {
                var msg = Db.Get<Message>(id);
                msg.IsRead = false;
                Db.Update(msg);
            }

            return Json(new { });
        }
    }
}