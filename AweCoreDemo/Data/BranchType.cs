using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoHms.Data
{
    public class BranchType
    {
        [Key]
        public int BranchTyeID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public List<Branch> Branches { get; set; } = new List<Branch>();
    }
}
