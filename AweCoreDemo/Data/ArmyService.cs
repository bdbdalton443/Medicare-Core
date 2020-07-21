using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoHms.Data
{
    public class ArmyService
    {
        private int _armyServiceID;
        private string _name, _description;
        [Key]
        public int ArmyServiceID { get => _armyServiceID; set => _armyServiceID = value; }
        public string Name { get => _name; set => _name = value; }
        public string Description { get => _description; set => _description = value; }
        public List<Patient> Patients { get; set; } = new List<Patient>();
    }
}
