using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoHms.Data
{
    public class NOKRelationship
    {
        [Key]
        public int NOKRelationshipID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<NextOfKin> NextOfKins { get; set; } = new List<NextOfKin>();
    }
}
