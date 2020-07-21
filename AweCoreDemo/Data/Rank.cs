using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoHms.Data
{
    public class Rank
    {
        private string _name, _code, _description;
        private int _rankID;
        [Key]
        public int RankID { get => _rankID; set => _rankID = value; }
        public string Name { get => _name; set => _name = value; }
        public string Code { get => _code; set => _code = value; }
        public string Description { get => _description; set => _description = value; }
        public List<Patient> Patients { get; set; } = new List<Patient>();
    }
}
