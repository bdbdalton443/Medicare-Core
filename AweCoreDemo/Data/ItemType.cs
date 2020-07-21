using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoHms
{
    public class ItemType
    {
        [Key]
        public int ItemTypeID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string SubGroup { get; set; }
        public int RefSubGroup { get; set; }
        public string CompleteName { get; set; }
        public int ItemSubGroupID { get; set; }
        public ItemSubGroup ItemSubGroup { get; set; }
        public List<Item> Items { get; set; } = new List<Item>();
    }
}
