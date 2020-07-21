using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

using Omu.AwesomeMvc;

namespace AweCoreDemo.ViewModels.Input
{
    public class UnobtrusiveInput
    {
        [Required]
        [AweMeta("placeholder", "write something")]
        [AweMeta("maxLength", 13)]
        [DisplayName("Textbox")]
        public string Name { get; set; }

        [Required]
        [AweMeta("placeholder", "only numbers here")]
        [AweMeta("decimals", 2)]
        [DisplayName("Numeric textbox")]
        public float? Number { get; set; }

        [Required]
        [UIHint("Autocomplete")]
        [AweMeta("placeholder", "try Mango")]
        [AweMeta("controller", "MealAutocomplete")]
        [DisplayName("Autocomplete")]
        public string MealAuto { get; set; }

        [Required]
        [AweMeta("Placeholder", "pick a date")]
        [DisplayName("DatePicker")]
        public DateTime? Date { get; set; }

        [Required]
        [UIHint("AjaxCheckboxList")]
        [AweUrl(Action = "GetCategories", Controller = "Data")]
        [DisplayName("CheckboxList")]
        public IEnumerable<int> Categories { get; set; }

        [Required]
        [UIHint("AjaxRadioList")]
        [AweUrl(Action = "GetCategories", Controller = "Data")]
        [DisplayName("RadioList")]
        public int? Category2 { get; set; }

        [Required]
        [DisplayName("Dropdown")]
        [AweUrl(Action = "GetCategoriesFirstOption", Controller = "Data")]
        [UIHint("AjaxDropdown")]
        public int? CategoryFo { get; set; }

        [Required]
        [UIHint("Lookup")]
        [AweMeta("ClearButton", true)]
        [DisplayName("Lookup")]
        public int? Meal { get; set; }

        [Required]
        [UIHint("MultiLookup")]
        [AweMeta("ClearButton", true)]
        [DisplayName("MultiLookup")]
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
        [DisplayName("Multiselect")]
        [AweUrl(Action = "GetCategories", Controller = "Data")]
        public int[] CategoriesMultiIds { get; set; }

        [Required]
        [UIHint("ColorDropdown")]
        [DisplayName("ColorPicker")]
        public string ColorId { get; set; }

        [Required]
        [UIHint("Combobox")]
        [DisplayName("Combobox")]
        [AweUrl(Action = "GetAllMeals", Controller = "Data")]
        public string MealComboId { get; set; }
        
        [DisplayName("Checkbox")]
        public bool Organic { get; set; }

        [UIHint("ChkEmpVal")]
        [Required(ErrorMessage = "This must be checked, in order to submit the form")]
        [DisplayName("Checkbox (Required)")]
        public bool Organic2 { get; set; }

        [UIHint("TogglEmpVal")]
        [Required(ErrorMessage = "This must be Yes, in order to submit the form")]
        [DisplayName("Toggle Button")]
        public bool Organic3 { get; set; }

        [UIHint("SchkEmpVal")]
        [Required(ErrorMessage = "This must be checked, in order to submit the form")]
        public bool OrganicSim { get; set; }
    }
}