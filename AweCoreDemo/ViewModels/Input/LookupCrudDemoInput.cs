using System.ComponentModel.DataAnnotations;

namespace AweCoreDemo.ViewModels.Input
{
    public class LookupCrudDemoInput
    {
        [Required]
        public int? Dinner2 { get; set; }

        [Required]
        public int[] Dinner3 { get; set; }
    }
}