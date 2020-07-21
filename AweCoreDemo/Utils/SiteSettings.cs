using AweCoreDemo.Models;
using AweCoreDemo.ViewModels.Input.Settings;
using Microsoft.AspNetCore.Http;

namespace AweCoreDemo.Utils
{
    public class SiteSettings
    {
        public static SettingsVal Read(HttpRequest request)
        {
            var settings = new SettingsVal();

            if (request.Cookies[DemoSettings.CookieName] != null)
            {
                var val = request.Cookies[DemoSettings.CookieName];
                settings.Theme = val;
            }

            if (string.IsNullOrWhiteSpace(settings.Theme))
            {
                settings.Theme = DemoSettings.DefaultTheme;
            }

            return settings;
        }
    }
}