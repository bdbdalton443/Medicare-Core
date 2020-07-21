using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoHms.Data
{
    public class Status
    {
        private string _name, _description;
        private int _statusID;
        [Key]
        public int StatusID { get => _statusID; set => _statusID = value; }
        public string Name { get => _name; set => _name = value; }
        public string Description { get => _description; set => _description = value; }
        public List<Hospital> Hospitals { get; set; } = new List<Hospital>();
    }
}
