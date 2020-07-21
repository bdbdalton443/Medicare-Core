using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoHms
{
    public class ItemUnit
    {
        [Key]
        public int ItemUnitID { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public List<Item> Items { get; set; } = new List<Item>();
    }
}
