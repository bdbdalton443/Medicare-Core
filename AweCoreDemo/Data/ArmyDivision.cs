using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoHms.Data
{
    public class ArmyDivision
    {
        private string _name, _code, _description;
        private int _armyDivisionID;
        [Key]
        public int ArmyDivisionID { get => _armyDivisionID; set => _armyDivisionID = value; }
        public string Name { get => _name; set => _name = value; }
        public string Code { get => _code; set => _code = value; }
        public string Description { get => _description; set => _description = value; }
        public List<ArmyUnit> ArmyUnits { get; set; } = new List<ArmyUnit>();
    }
}
