using Omu.AwesomeMvc;

namespace AweCoreDemo.ViewModels.Display
{
    public class MealDisplay : KeyContent
    {
        public MealDisplay(object key, string content, string url)
            : base(key, content)
        {
            this.url = url;
        }

        public string url { get; set; }
    }
}