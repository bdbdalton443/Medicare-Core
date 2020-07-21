using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoHms.Pages.Extensions
{
    public static class DemoUtils
    {
        public static string MealsUrl = "~/Content/Pictures/Meals/";

        public static void TryError()
        {
            var random = new Random();
            if (random.Next(10) > 5)
            {
                throw new Exception("a demo exception has occurred");
            }
        }

        public static void Error()
        {
            throw new Exception("a demo exception has occurred");
        }

        public static string Encode(object input)
        {
            return Autil.JsonEncode(input);
        }

        public static string RndName()
        {
            var names = new[] { "hi there", "orange", "asdfa", "peas", "cabbage" };
            return names[new Random().Next(names.Length)];
        }
    }
}
