using System.Text;
using Microsoft.AspNetCore.Html;
using Omu.AwesomeMvc;

namespace Omu.Awem.Helpers
{
    /// <summary>
    /// 
    /// </summary>
    public static class AwesomeHtmlHelperExtensions
    {
        /// <summary>
        /// Initializes awesome and aweui (if present), by generating a script that will
        /// set the defaults for awem.js and jquery.validate (if present); 
        /// sets date format, first day of week, decimal separator, isMobileOrTablet
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ahtml"></param>
        /// <param name="isMobile"></param>
        /// <returns></returns>
        public static IHtmlContent Init<T>(this AwesomeHtmlHelper<T> ahtml, bool? isMobile = null)
        {
            var isMobileOrTablet = (isMobile ?? Autil.IsMobileOrTablet(ahtml)) ? 1 : 0;
            var dateFormat = AweUtil.ConvertTojQueryDateFormat(Autil.CurrentCulture().DateTimeFormat.ShortDatePattern);
            var decimalSep = Autil.CurrentCulture().NumberFormat.NumberDecimalSeparator;

            var sb = new StringBuilder("<script>");
            sb.AppendFormat("awem.isMobileOrTablet = function() {{ return {0}; }};", isMobileOrTablet);
            sb.AppendFormat("awem.fdw = {0};", (int)Autil.CurrentCulture().DateTimeFormat.FirstDayOfWeek);
            sb.AppendFormat("utils.init('{0}', {1}, '{2}');", dateFormat, isMobileOrTablet, decimalSep);
            sb.AppendFormat("if(window.aweui){{aweui.init(); aweui.decimalSep = '{0}';}}", decimalSep);
            sb.Append("</script>");

            return new HtmlString(sb.ToString());
        }
    }
}