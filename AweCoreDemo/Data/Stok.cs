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
    public class Stok:BaseEntity
    {
        [Key]
        public int? StockID { get; set; }
        public string ItemName { get; internal set; }
        public int? Quantity { get; set; }

        //[Display(Name = "Item")]
        public int? ItemID { get; set; }
        [ForeignKey("ItemID")]
        public Item Item { get; set; }

        //[Display(Name = "Department")]
        public int? DepartmentID { get; set; }
        [ForeignKey("DepartmentID")]
        public Department Department { get; set; }
        public bool Available { get; set; }
        public string Description { get; set; }
    }
}
