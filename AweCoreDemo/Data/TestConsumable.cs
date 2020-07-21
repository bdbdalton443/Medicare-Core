using DemoHms;
using DemoHms.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AweCoreDemo.Data
{
    public class TestConsumable
    {
        [Key]
        public int? TestConsumableID { get; set; }
        public int? TestID { get; set; }
        [ForeignKey("TestID")]
        public Test Test { get; set; }
        public int? ItemID { get; set; }
        [ForeignKey("ItemID")]
        public Item Item { get; set; }
        public int? Quantity { get; set; }

    }
}
