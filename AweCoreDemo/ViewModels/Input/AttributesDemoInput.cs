using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Omu.AwesomeMvc;

namespace AweCoreDemo.ViewModels.Input
{
    /*begin*/
    public class AttributesDemoInput
    {
        [Required]
        [AweMeta("min", 30)]
        [AweMeta("max", 100)]
        public int? Number { get; set; }

        [Required]
        [UIHint("Odropdown")]
        [DisplayName("Parent category")]
        [AweUrl(Action = "GetCategories", Controller = "Data")]
        public int? ParentCategory { get; set; }

        [Required]
        [UIHint("AjaxDropdown")]
        [DisplayName("Child meal")]
        [AweUrl(Action = "GetMeals", Controller = "Data")]
        [AweParent("ParentCategory", "categories")]
        [AweParam("categories", 157)]
        public int? Meal1 { get; set; }

        [Required]
        [UIHint("Odropdown")]
        [DisplayName("Child meal 2")]
        [AweUrl(Action = "GetMeals", Controller = "Data")]
        [AweParent("ParentCategory", "categories")]
        public int? Meal2 { get; set; }

        [Required]
        [UIHint("Lookup")]
        [DisplayName("Meal custom search")]
        [Lookup(ClearButton = true, Title = "this is a lookup with custom search", CustomSearch = true)]
        public int? MealCustomSearch { get; set; }

        [Required]
        [UIHint("MultiLookup")]
        [DisplayName("Meals multi")]
        [MultiLookup(ClearButton = true, Controller = "MealsMultiLookup", Title = "select some stuff")]
        public IEnumerable<int> SomeMeals { get; set; }

        [Required]
        [UIHint("AjaxCheckboxList")]
        [AweUrl(Action = "GetCategories", Controller = "Data")]
        public IEnumerable<int> SomeCategories { get; set; }

        [UIHint("Hidden")]
        public int? MealId { get; set; }

        [Required]
        [UIHint("Autocomplete")]
        [Autocomplete(Controller = "MealAutocomplete", Prefix = "eg", MinLength = 2, Delay = 500, PropId = "MealId")]
        [AweMeta("Placeholder", "try Ma...")]
        public string MealAuto { get; set; }

        [AweMeta("Placeholder", "please pick date")]
        [AweMeta("ClearButton", true)]
        public DateTime? Date { get; set; }
    }
    /*end*/
}