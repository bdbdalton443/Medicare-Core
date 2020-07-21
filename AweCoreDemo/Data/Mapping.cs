using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoHms.Data
{
    public class Mapping
    {
        int _mappingID, _ref_Module;

        [Key]
        public int MappingID { get => _mappingID; set => _mappingID = value; }
        public int HospitalID { get; set; }
        [ForeignKey("HospitalID")]
        public Hospital Hospital { get; set; }
        public int ModuleID { get => _ref_Module; set => _ref_Module = value; }
        [ForeignKey("ModuleID")]
        public Module Module { get; set; }
    }
}
