using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Omu.AwesomeMvc;

namespace AweCoreDemo.ViewModels.Input
{
    public class ParentMealInput
    {
        public int? Id { get; set; }

        [Required]
        [UIHint("Odropdown")]
        [AweUrl(Action = "GetCategories", Controller = "Data")]
        [DisplayName("Category")]
        public int? CategoryId { get; set; }

        [Required]
        [UIHint("Odropdown")]
        [AweUrl(Action = "GetAllMeals", Controller = "Data")]
        [DisplayName("Meal")]
        public int? MealId { get; set; }
    }
}