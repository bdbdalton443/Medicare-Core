using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoHms.Data
{
    public class Examination:BaseEntity
    {
        [Key]
        public int ExaminationID { get; set; }
        private string Name { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public string Code { get; set; }

        [DataType(DataType.MultilineText)]
        public string Findings { get; set; }
        public int? ExaminationStatusID { get; set; }
        [ForeignKey("ExaminationStatusID")]
        [Display(Name = "Examination Status")]
        public ExaminationStatus ExaminationStatus { get; set; }
        public int? BillStatusID { get; set; }
        [ForeignKey("BillStatusID")]
        [Display(Name = "Bill Status")]
        public BillStatus BillStatus { get; set; }
        public int? AssignmentID { get; set; }
        [ForeignKey("AssignmentID")]
        [Display(Name = "Assignment")]
        public Assignment Assignment { get; set; }
        public int? BillID { get; set; }
        [ForeignKey("BillID")]
        public Bill Bill { get; set; }
        public List<Procedure> Procedures { get; set; } = new List<Procedure>();

    }
}
