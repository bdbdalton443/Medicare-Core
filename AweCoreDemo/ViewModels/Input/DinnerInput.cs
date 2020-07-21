using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using AweCoreDemo.ViewModels.Attributes;
using Omu.AwesomeMvc;

namespace AweCoreDemo.ViewModels.Input
{
    public class DinnerInput
    {
        public int? Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public DateTime? Date { get; set; }

        [UIHint("MultiLookupDropdown")]
        [Required]
        [CollectionMaxLen(7)]
        public IEnumerable<int> Meals { get; set; }

        [UIHint("LookupDropdown")]
        [Required]
        public int? Chef { get; set; }

        [Required]
        [UIHint("Odropdown")]
        [AweUrl(Action = "GetAllMeals", Controller = "Data")]
        [DisplayName("Bonus meal")]
        public int? BonusMealId { get; set; }

        public bool? Organic { get; set; }
    }
}