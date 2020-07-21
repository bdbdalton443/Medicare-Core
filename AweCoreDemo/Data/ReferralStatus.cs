using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoHms.Data
{
    public class ReferralStatus
    {
        [Key]
        public int ReferralStatusID { get; set; }
        public string Name { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public List<Assignment> Assignments { get; set; } = new List<Assignment>();
    }
}
