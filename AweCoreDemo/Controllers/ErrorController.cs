using System;
using Microsoft.AspNetCore.Mvc;
using AweCoreDemo.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Diagnostics;
using AweCoreDemo.Utils;
using Microsoft.Extensions.Hosting;

namespace AweCoreDemo.Controllers
{
    public class ErrorController : Controller
    {
        private readonly IWebHostEnvironment env;

        public ErrorController(IWebHostEnvironment env)
        {
            this.env = env;
        }

        public IActionResult Index(Exception error)
        {
            var exceptionFeature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();

            if (exceptionFeature != null)
            {
                error = exceptionFeature.Error;
            }

            SetMessage(error);

            if (error.Message != null && error.Message.Contains("The parameters dictionary contains") 
                || error is AweArgumentNullException
                || error is EntityMissingException)
            {
                Response.StatusCode = 400;

                if (Request.IsAjaxRequest())
                {
                    return PartialView("Resource400");
                }

                return View("Resource400");
            }

            if (error is AwesomeDemoException)
            {
                if (Request.IsAjaxRequest())
                {
                    return PartialView("Expected");
                }

                return View("Expected");
            }

            if (Response.StatusCode == 200)
            {
                Response.StatusCode = 500;
            }

            if (Request.IsAjaxRequest())
            {
                return PartialView("ErrorPartial");
            }

            return View("Error");
        }

        public IActionResult Master(Exception error)
        {
            SetMessage(error);

            return View();
        }

        public IActionResult HttpStatus(int? code)
        {
            var feature = Request.HttpContext.Features.Get<IStatusCodeReExecuteFeature>();
            var path = feature.OriginalPath;            

            if (code == 404)
            {
                Response.StatusCode = 404;

                if (Request.IsAjaxRequest() || path.EndsWith(".map"))
                {
                    return Content("404 not found");
                }

                return View("HttpError404");
            }
            else if (code == 400)
            {
                Response.StatusCode = 400;

                return Content("400 bad request");
            }
            else if (code == 505)
            {
                if (Request.IsAjaxRequest())
                {
                    return Content("please try again later");
                }

                return View("HttpError505");
            }

            return Content("");
        }

        private void SetMessage(Exception error)
        {
            if (env.IsDevelopment())
            {
                ViewData["debugInfo"] = "This message is showing because ASPNETCORE_ENVIRONMENT is Development";
                ViewData["message"] = error.ToString();
            }
            else
            {
                ViewData["debugInfo"] = "Set ASPNETCORE_ENVIRONMENT to Development too se more details";
                ViewData["message"] = Message(error);
            }
        }

        private string Message(Exception ex)
        {
            if (ex == null) return "";
            return ex.Message + "\n" + Message(ex.InnerException);
        }
    }
}