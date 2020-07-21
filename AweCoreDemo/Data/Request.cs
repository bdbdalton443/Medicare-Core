using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoHms
{
    public class Request
    {
        [Key]
        public int RequestID { get; private set; }
        public string Name { get; set; }
        public string RequestedBy { get; set; }
        public string Department { get; set; }
        public string Status { get; set; }
        public int Quantity { get; set; }
        public int IssuedQty { get; set; }
        public int ApprovedQty { get; set; }
        public DateTime Requested_On { get; set; }
        public int Balance { get; set; }
        public DateTime Approved_On { get; set; }
        public bool Received { get; set; }
        public bool Confirmed { get; set; }
        public bool Appoved { get; set; }
        public bool Issued { get; set; }

        [NotMapped]
        public string RequestedItem { get { return Item.Name; } }
        [Display(Name ="Item")]
        public int ItemID { get; set; }
        [ForeignKey("ItemID")]
        public Item Item { get; set; }
    }
}
