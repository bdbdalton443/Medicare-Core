using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoHms.Data
{
    public class Family
    {
        [Key]
        public int FamilyID { get; set; }
        public string Name { get; set; }
        [Phone]
        public string Telephone { get; set; }
        public int Credit { get; set; }
        public int Debit { get; set; }
        public string Address { get; set; }
        public string NickName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public int MaxCredit { get; set; }
        public int OSBalance { get; set; }
        public int InitialDeposit { get; set; }
        public List<Patient> Patients { get; set; } = new List<Patient>();
    }
}
