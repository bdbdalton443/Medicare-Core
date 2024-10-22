using System.ComponentModel.DataAnnotations;

namespace AweCoreDemo.ViewModels.Input
{
    public class TreeNodeInput
    {
        public int Id { get; set; }

        public int ParentId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}