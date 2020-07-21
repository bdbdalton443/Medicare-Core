using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

using Omu.AwesomeMvc;

namespace AweCoreDemo.ViewModels.Input
{
    public class UnobstrusiveInput
    {
        [Required]
        [AweMeta("placeholder", "write something")]
        [AweMeta("maxLength", 13)]
        public string Name { get; set; }

        [Required]
        [AweMeta("placeholder", "only numbers here")]
        [AweMeta("decimals", 2)]
        public float? Number { get; set; }

        [Required]
        [UIHint("Autocomplete")]
        [AweMeta("placeholder", "try Mango")]
        [AweMeta("controller", "MealAutocomplete")]
        [DisplayName("Meal auto")]
        public string MealAuto { get; set; }

        [Required]
        [AweMeta("Placeholder", "pick a date")]
        public DateTime? Date { get; set; }

        [Required]
        [UIHint("AjaxCheckboxList")]
        [AweUrl(Action = "GetCategories", Controller = "Data")]
        public IEnumerable<int> Categories { get; set; }

        [Required]
        [UIHint("AjaxRadioList")]
        [AweUrl(Action = "GetCategories", Controller = "Data")]
        public int? Category2 { get; set; }

        [Required]
        [DisplayName("Category")]
        [AweUrl(Action = "GetCategoriesFirstOption", Controller = "Data")]
        [UIHint("AjaxDropdown")]
        public int? CategoryFo { get; set; }

        [Required]
        [UIHint("Lookup")]
        [AweMeta("ClearButton", true)]
        public int? Meal { get; set; }

        [Required]
        [UIHint("MultiLookup")]
        [AweMeta("ClearButton", true)]
        public IEnumerable<int> Meals { get; set; }

        [Required]
        [UIHint("Odropdown")]
        [DisplayName("Odropdown")]
        [AweUrl(Action = "GetAllMeals", Controller = "Data")]
        public int? MealsOdd { get; set; }

        [Required]
        [UIHint("ButtonGroupRadio")]
        [DisplayName("ButtonGroup")]
        [AweUrl(Action = "GetCategories", Controller = "Data")]
        public int? CategoryBgrId { get; set; }

        [Required]
        [UIHint("ButtonGroupCheckbox")]
        [DisplayName("ButtonGroup Multi")]
        [AweUrl(Action = "GetCategories", Controller = "Data")]
        public int[] CategoriesBgcIds { get; set; }

        [Required]
        [UIHint("Multiselect")]
        [DisplayName("Categories Multi")]
        [AweUrl(Action = "GetCategories", Controller = "Data")]
        public int[] CategoriesMultiIds { get; set; }

        [Required]
        [UIHint("ColorDropdown")]
        [DisplayName("Color")]
        public string ColorId { get; set; }

        [Required]
        [UIHint("Combobox")]
        [DisplayName("Meal Combo")]
        [AweUrl(Action = "GetAllMeals", Controller = "Data")]
        public string MealComboId { get; set; }
    }
}