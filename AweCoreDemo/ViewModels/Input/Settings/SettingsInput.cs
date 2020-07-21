using System.Collections.Generic;

using Omu.AwesomeMvc;

namespace AweCoreDemo.ViewModels.Input.Settings
{
    public class SettingsInput
    {
        public IEnumerable<KeyContent> Themes { get; set; }
        
        public string SelectedTheme { get; set; }        
    }
}