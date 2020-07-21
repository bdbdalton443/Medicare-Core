﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Reflection;

namespace DemoHms.Pages.Extensions
{
    public static class Autil
    {
        public static string ToShortDateString(this DateTime input)
        {
            return input.ToString("d");
        }

        public static string ToLongTimeString(this DateTime input)
        {
            return input.ToString("T");
        }

        public static bool IsAjaxRequest(this HttpRequest request)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));

            if (request.Headers != null)
                return request.Headers["X-Requested-With"] == "XMLHttpRequest";
            return false;
        }

        public static string ServerMapPath(this IHtmlHelper html)
        {
            return ((IWebHostEnvironment)html.ViewContext.HttpContext.RequestServices.GetService(typeof(IWebHostEnvironment))).ContentRootPath + "\\";
        }

        public static string JsonEncode(object o)
        {
            return JsonConvert.SerializeObject(o, Formatting.None, new JsonSerializerSettings { StringEscapeHandling = StringEscapeHandling.EscapeHtml });
        }

        internal static PropertyInfo GetProperty(this Type type, string name)
        {
            return type.GetTypeInfo().GetProperty(name);
        }

        public static string CssDir()
        {
            return "~/css/";
        }

        public static string JsDir()
        {
            return "~/js/";
        }
    }
}
