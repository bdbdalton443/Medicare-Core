using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoHms.Data
{
    public class Procedure:BaseEntity
    {
        [Key]
        public int? ProcedureID { get; set; }
        public int? TestID { get; set; }
        [ForeignKey("TestID")]
        [Display(Name = "Test")]
        public Test Test { get; set; }
        public string Description { get; set; }
        public string Findings { get; set; }
        public int? ExaminationID { get; set; }
        [ForeignKey("ExaminationID")]
        [Display(Name = "Examination")]
        public Examination Examination { get; set; }
        public int? ExaminationStatusID { get; set; }
        [ForeignKey("ExaminationStatusID")]
        [Display(Name = "Procedure Status")]
        public ExaminationStatus ExaminationStatus { get; set; }
        public int? BillID { get; set; }
        [ForeignKey("BillID")]
        public Bill Bill { get; set; }
        public int? OriginalAmount { get; set; }
        public int? AdjustedAmount { get; set; }
        public List<Receipt> Receipts { get; set; } = new List<Receipt>();
    }
}
