using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoHms.Data
{
    public class Assignment:BaseEntity
    {
        [Key]
        public int? AssignmentID { get; set; }
        public string Description { get; set; }
        public bool Emergency { get; set; }
        public string Recommendation { get; set; }
        public DateTime LastVisted { get; set; }
        public bool Deleted { get; set; }
        public DateTime Reported { get; set; }
        public int PatientID { get; set; }
        [ForeignKey("PatientID")]
        [Display(Name ="Patient")]
        public Patient Patient { get; set; }
        public int? ReferralStatusID { get; set; }
        [ForeignKey("ReferralStatusID")]
        [Display(Name = "Referral Status")]
        public ReferralStatus ReferralStatus { get; set; }
        public int? PatientTypeID { get; set; }
        [ForeignKey("PatientTypeID")]
        [Display(Name = "Patient Type")]
        public PatientType PatientType { get; set; }
        
        public int? BillStatusID { get; set; }
        [ForeignKey("BillStatusID")]
        [Display(Name = "Bill Status")]
        public BillStatus BillStatus { get; set; }
        public string DoctorID { get; set; }
        [ForeignKey("DoctorID")]
        [Display(Name = "Doctor")]
        public ApplicationUser Doctor { get; set; }
        public List<Examination> Examinations { get; set; } = new List<Examination>();
        public List<Treatment> Treatments { get; set; } = new List<Treatment>();
  
    }
}
