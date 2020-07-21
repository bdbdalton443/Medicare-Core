using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoHms.Data
{
    public class Activity
    {
        public int ActivityID { get; set; }
        public string Name { get; set; }
        public string ActivityCode { get; set; }
        public List<Permission> Permissions { get; set; } = new List<Permission>();
    }
}
