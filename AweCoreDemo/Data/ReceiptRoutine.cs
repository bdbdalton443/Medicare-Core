using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DemoHms
{
    public class ReceiptRoutine
    {
        [Key]
        public int ReceiptRoutineID { get; set; }
        [Required]
        public string ReceiptNumber { get; set; }
        public int Amount { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public int BillID { get; set; }
        [ForeignKey("BillID")]
        [Display(Name = "Bill")]
        public Bill Bill { get; set; }
    }
}
