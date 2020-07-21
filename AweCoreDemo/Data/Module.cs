using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoHms.Data
{
    public class Module
    {
        [Key]
        public int ModuleID { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public List<Mapping> Mappings { get; set; } = new List<Mapping>();
    }
}
