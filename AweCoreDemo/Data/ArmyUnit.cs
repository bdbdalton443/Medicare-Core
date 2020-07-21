using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoHms.Data
{
    public class ArmyUnit
    {
        private string _name, _description;
        private int _armyUnitID, _armyDivisionID;
        private string _code;
        [Key]
        public int ArmyUnitID { get => _armyUnitID; set => _armyUnitID = value; }
        public int? ArmyDivisionID { get => _armyDivisionID; set => _armyDivisionID = (int)value; }
        [ForeignKey("ArmyDivisionID")]
        public ArmyDivision ArmyDivision { get; set; }
        public string Name { get => _name; set => _name = value; }
        public string Code { get => _code; set => _code = value; }
        public string Description { get => _description; set => _description = value; }
        public List<Patient> Patients { get; set; } = new List<Patient>();
    }
}
