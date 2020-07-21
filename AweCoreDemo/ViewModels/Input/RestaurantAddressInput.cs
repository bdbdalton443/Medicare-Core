using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Omu.AwesomeMvc;

namespace AweCoreDemo.ViewModels.Input
{
    public class RestaurantAddressInput
    {
        public int? Id { get; set; }

        [UIHint("Hidden")]
        public int RestaurantId { get; set; }

        [Required]
        public string Line1 { get; set; }

        public string Line2 { get; set; }

        [Required]
        [UIHint("Odropdown")]
        [AweUrl(Action = "GetChefs", Controller = "Data")]
        [DisplayName("Chef")]
        public int? ChefId { get; set; }
    }
}