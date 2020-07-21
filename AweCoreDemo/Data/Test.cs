using AweCoreDemo.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoHms.Data
{
    public class Test
    {
        [Key]
        public int TestID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int? DepartmentID { get; set; }
        [ForeignKey("DepartmentID")]
        public Department Department { get; set; }
        public List<Item> Items { get; set; } = new List<Item>();
        public List<TestConsumable> TestConsumables { get; set; } = new List<TestConsumable>();
        public List<Procedure> Procedures { get; set; } = new List<Procedure>();
    }
}
