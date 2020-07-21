using System.ComponentModel.DataAnnotations;

namespace AweCoreDemo.ViewModels.Input
{
    public class PopupConfirmInput
    {
        [Required]
        public string Name { get; set; }
    }
}