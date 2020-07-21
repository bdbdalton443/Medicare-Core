using DemoHms.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DemoHms
{
    public class Receipt
    {
        public int ReceiptID { get; set; }

        [MaxLength(15)]
        public string? ReceiptNumber { get; set; }
        public int? Amount { get; set; }
        public int? AdjustedAmount { get; set; }
        public int? AdjustedCost { get; set; }
        public string Description { get; set; }
        public int? Cost { get; set; }
        public int? BillID { get; set; }
        [ForeignKey("BillID")]
        public Bill Bill { get; set; }
        public int? TreatmentID { get; set; }
        [ForeignKey("TreatmentID")]
        public Treatment Treatment { get; set; }
        public int? ProcedureID { get; set; }
        [ForeignKey("ProcedureID")]
        public Procedure Procedure { get; set; }
    }
}
