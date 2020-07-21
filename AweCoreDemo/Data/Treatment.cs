using AweCoreDemo.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoHms.Data
{
    [Table("Treatments")]
    public class Treatment:BaseEntity
    {
        [Key]
        public int? TreatmentID { get; set; }
        [NotMapped]
        public string Name
        {
            get
            {
                return Item!=null?Item.Name:"";
            }
        }
        public string Description { get; set; }
        public int? Days { get; set; }
        public int? PreQuantity { get; set; }
        [NotMapped]
        public string X { get { return "X"; } }
        public int? PostQuantity { get; set; }
        public int? OriginalAmount { get; set; }
        public int? AdjustedAmount { get; set; }
        public int? ItemID { get; set; }
        [ForeignKey("ItemID")]
        public Item Item { get; set; }
        public int? BIllID { get; set; }
        [ForeignKey("BIllID")]
        public Bill Bill { get; set; }
        public int? AssignmentID { get; set; }
        [ForeignKey("AssignmentID")]
        [Display(Name = "Assignment")]
        public Assignment Assignment { get; set; }
        [Display(Name = "Dispense Status")]
        public int? DispenseStatusID { get; set; }
        [ForeignKey("DispenseStatusID")]       
        public DispenseStatus DispenseStatus { get; set; }
        public List<Receipt> Receipts { get; set; } = new List<Receipt>();
        public int? DispensedQty { get; set; }
        public int? Balance { get; set; }
    }
}
