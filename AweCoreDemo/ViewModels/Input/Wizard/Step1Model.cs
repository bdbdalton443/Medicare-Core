using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

using Omu.AwesomeMvc;

namespace AweCoreDemo.ViewModels.Input.Wizard
{
    public class Step1Model
    {
        public string WizardId { get; set; }

        [Required]
        [AweMeta("Placeholder", "type a name here")]
        public string Name { get; set; }

        [Required]
        [UIHint("Odropdown")]
        [DisplayName("Category")]
        [AweUrl(Controller = "Data", Action = "GetCategories")]
        public int? CategoryId { get; set; }
    }
}