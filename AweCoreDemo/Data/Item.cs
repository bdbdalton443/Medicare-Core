using DemoHms.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoHms
{
    public class Item
    {
        
        [Key]
        public int ItemID { get; set; }
        public string Name { get; set; }
        public string ExtendedName { get; set; }
        public string Code { get; set; }
        public string TradeName { get; set; }
        public string PackageName { get; set; }
        public string PackageDesc { get; set; }
        public string Manufacturer { get; set; }
        public int ItemsPerPkg { get; set; }
        [Display(Name ="Supplier")]
        public int? SupplierID { get; set; }
        [ForeignKey("SupplierID")]
        public Supplier Supplier { get; set; }
        public int ItemTypeID { get; set; }
        public ItemType ItemType { get; set; }
        public int ItemUnitID { get; set; }
        public ItemUnit ItemUnit { get; set; }
        public string ModifiedByUserId { get; set; }

        [ForeignKey("ModifiedByUserId")]
        public ApplicationUser ModifiedByUser { get; set; }
        public string? ApplicationUserId { get; set; }

        [ForeignKey("ApplicationUserId")]
        public ApplicationUser CreatedByUser { get; set; }
        public List<Request> Requests { get; set; } = new List<Request>();
        public List<Treatment> Treatment { get; set; } = new List<Treatment>();
    }
}
