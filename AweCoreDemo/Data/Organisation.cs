using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoHms.Data
{
    public class Organisation
    {
        [Key]
        public int OrganisationID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public int Credit { get; set; }
        public int Debit { get; set; }
        public int Charge { get; set; }
        public List<Patient> Patients { get; set; } = new List<Patient>();
    }
}
