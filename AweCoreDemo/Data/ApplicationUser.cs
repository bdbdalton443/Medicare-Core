using DemoHms.Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoHms
{
    public class ApplicationUser: IdentityUser
    {
        public string FirstName { get;  set; }
        public string LastName { get; set; }
        [NotMapped]
        public string FullName { get { return LastName + " " + FirstName; } }
        public override string Email { get => base.Email; set => base.Email = value; }
        public override string PasswordHash { get => base.PasswordHash; set => base.PasswordHash = value; }
        [Display(Name = "Role")]
        public int? EmployeeGroupID { get; set; }
       
        [ForeignKey("EmployeeGroupID")]
        public EmployeeGroup EmployeeGroup { get; set; }
        [Display(Name ="Hospital")]
        public int? HospitalId { get; set; }

        [ForeignKey("HospitalId")]
        public Hospital Hospital { get; set; }

        [Display(Name = "Department")]
        public int? DepartmentID { get; set; }

        [ForeignKey("DepartmentID")]
        public Department Department { get; set; }
        public List<Assignment> Assignments { get; set; } = new List<Assignment>();
        //public List<BillItem> BillItems { get; set; } = new List<BillItem>();
        //public List<Examination> Examinations { get; set; } = new List<Examination>();
        //public List<NextOfKin> NextOfKins { get; set; } = new List<NextOfKin>();
    }
     
}
