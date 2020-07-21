using DemoHms.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AweCoreDemo.Data
{
    public class HService
    {
        [Key]
        public int HServiceID { get; set; }
        public string Name { get; set; }
        public List<BillItem> BillItems { get; set; } = new List<BillItem>();
    }
}
