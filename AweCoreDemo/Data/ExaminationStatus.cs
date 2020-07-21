using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoHms.Data
{
    public class ExaminationStatus
    {
        [Key]
        public int ExaminationStatusID { get; set; }
        public string Name { get; set; }
        public List<Examination> Examinations { get; set; } = new List<Examination>();
        public List<Procedure> Procedures { get; set; } = new List<Procedure>();
    }
}
