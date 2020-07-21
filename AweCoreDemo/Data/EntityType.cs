using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoHms.Data
{
    public class EntityType
    {
        public int EntityTypeID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Hospital> Hospitals { get; set; } = new List<Hospital>();
    }
}
