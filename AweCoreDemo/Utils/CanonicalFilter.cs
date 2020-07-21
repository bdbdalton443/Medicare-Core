using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AweCoreDemo.Utils
{
    public class CanonicalFilter : IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var rdcontroller = context.RouteData.Values["controller"] as string;
            var rdaction = context.RouteData.Values["action"] as string;
            var path = context.HttpContext.Request.Path.Value;

            var actionDescriptor = (ControllerActionDescriptor)context.ActionDescriptor;
            var controller = actionDescriptor.ControllerName;
            var action = actionDescriptor.ActionName;

            if (action != rdaction || controller != rdcontroller)
            {
                context.RouteData.Values["action"] = action;

                path = path.Replace(rdcontroller, controller).Replace(rdaction, action);
                context.Result = new RedirectResult(path, true);
            }
        }
    }
}