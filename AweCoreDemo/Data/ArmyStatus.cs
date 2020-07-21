using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoHms.Data
{
    public class ArmyStatus
    {
        [Key]
        public int ArmyStatusID { get; set; }
        public string Name { get; set; }
        public List<Patient> Patients { get; set; } = new List<Patient>();
    }
}
