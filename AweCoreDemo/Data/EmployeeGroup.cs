using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoHms.Data
{
    public class EmployeeGroup
    {
        [Key]
        public int EmployeeGroupID { get; set; }
        public string Name { get; set; }
        public string Groupcode { get; set; }
        public List<Permission> Permissions { get; set; } = new List<Permission>();
        public List<ApplicationUser> AppUsers { get; set; } = new List<ApplicationUser>();
    }
}
