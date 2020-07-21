using DemoHms.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

//public enum BillStatus
//{
//    [Description("New")]
//    New = 1,
//    [Description("Open")]
//    Open = 2,
//    [Description("Pending")]
//    Pending = 3,
//    [Description("Closed")]
//    Closed = 4,
//    Paid = 5,
//    Dispense = 6,
//    Forwarded = 7,
//    ForwardService,
//    PendingLab,
//    PendingDispense,
//    PendingService,
//    CompletedLab,
//    CompletedDispense,
//    CompletedService
//}
namespace DemoHms
{
    public class Bill:BaseEntity
    {
        public int BIllID { get; set; }
        public int? Balance { get; set; }
        public bool InitialPrint { get; set; }
        public bool FinalPrint { get; set; }
        public int? BillStatusID { get; set; }
        [ForeignKey("BillStatusID")]
        [Display(Name = "Bill Status")]
        public BillStatus BillStatus { get; set; }
        public int? PatientID { get; set; }
        [ForeignKey("PatientID")]
        public Patient Patient { get; set; }
        public new int? Total { get; set; }
        public List<Receipt> Receipts { get; set; } = new List<Receipt>();
        public List<ReceiptRoutine> ReceiptRoutines { get; set; } = new List<ReceiptRoutine>();
        public List<Treatment> Treatments { get; set; } = new List<Treatment>();
        public List<Procedure> Procedures { get; set; } = new List<Procedure>();
        public List<Examination> Examinations { get; set; } = new List<Examination>();
    }
}
