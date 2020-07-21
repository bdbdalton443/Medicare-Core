using System;
using Microsoft.AspNetCore.Mvc;

namespace AweCoreDemo.Controllers.Demos.Generic
{
    public class ErrorHandlingDemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowPopup()
        {
            throw new Exception("Popup example error message");
        }

        public IActionResult ShowPopupForm()
        {
            throw new Exception("PopupForm example error message");
        }

        public IActionResult ErrOnPost()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult ErrOnPost(string foo)
        {
            throw new Exception("example error message");
        }
    }
}