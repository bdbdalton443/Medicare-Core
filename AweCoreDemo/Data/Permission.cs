using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoHms.Data
{
    public class Permission:BaseEntity
    {
        [Key]
        public int PermissionID { get; set; }
        public string Name { get; set; }
        public bool CanEdit { get; set; }
        public bool CanRead { get; set; }
        public bool CanDelete { get; set; }
        public bool CanAdd { get; set; }
        public bool CanApprove { get; set; }
        public bool CanConfirm { get; set; }
        [Display(Name="Name")]
        public int? EmployeeGroupID { get; set; }

        [ForeignKey("EmployeeGroupID")]
        public EmployeeGroup EmployeeGroup { get; set; }

        [Display(Name = "Name")]
        public int? ActivityID { get; set; }

        [ForeignKey("ActivityID")]
        public Activity Activity { get; set; }
    }
}
