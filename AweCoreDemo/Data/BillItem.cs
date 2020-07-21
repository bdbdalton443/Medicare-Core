using AweCoreDemo.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
namespace DemoHms.Data
{
    /// <summary>
    /// Summary description for BillItem
    /// </summary>
    public class BillItem : BaseEntity
    {
        [Key]
        public int BillItemID { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public int? BillItemTypeID { get; set; }
        [ForeignKey("BillItemTypeID")]
        public BillItemType BillItemType { get; set; }
        public int? ItemID { get; set; }
        [ForeignKey("ItemID")]
        public Item Item{ get; set; }
        public int? TestID { get; set; }
        [ForeignKey("TestID")]
        public Test Test { get; set; }
        public int? HServiceID { get; set; }
        [ForeignKey("HServiceID")]
        public HService HService { get; set; }

    }
}