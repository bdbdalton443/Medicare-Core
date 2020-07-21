using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoHms.Data
{
    public class Department
    {
        [Key]
        public int DepartmentID { get; set; }
        public string Name { get; set; }
        [Phone]
        public string Telephone { get; set; }
        public string Fax { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Code { get; set; }
        public int? BranchID { get; set; }
        [ForeignKey("BranchID")]
        public Branch Branch { get; set; }
        public List<Patient> Patients { get; set; } = new List<Patient>();
        public List<ApplicationUser> AppUsers { get; set; } = new List<ApplicationUser>();
        public List<Test> Tests { get; set; } = new List<Test>();
    }
}
