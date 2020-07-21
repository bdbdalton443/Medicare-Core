using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoHms.Data
{
    public class BillStatus
    {
        [Key]
        public int BillStatusID { get; set; }
        public string Name { get; set; }
        public List<Bill> Bills { get; set; } = new List<Bill>();
        public List<Examination> Examinations { get; set; } = new List<Examination>();
        public List<Assignment> Assignments { get; set; } = new List<Assignment>();
    }
}
