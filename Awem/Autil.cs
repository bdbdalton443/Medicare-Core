using System;
using System.Globalization;
using Newtonsoft.Json;
using Omu.AwesomeMvc;
using Omu.Awem.Utils;

namespace Omu.Awem
{
    internal static class Autil
    {
        internal static string Serialize(object input)
        {
            return JsonConvert.SerializeObject(input);
        }

        internal static CultureInfo CurrentCulture()
        {
            return CultureInfo.CurrentCulture;
        }

        internal static string ToShortDateString(this DateTime input)
        {
            return input.ToString("d");
        }

        internal static bool IsMobileOrTablet<T>(AwesomeHtmlHelper<T> ahtml)
        {
            return MobileUtils.IsMobileOrTablet(ahtml.Html.ViewContext.HttpContext.Request);
        }
    }
}