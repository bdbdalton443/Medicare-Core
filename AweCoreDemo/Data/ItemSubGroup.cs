using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoHms
{
    public class ItemSubGroup
    {
        public string Code { get; set; }
        [Key]
        public int ItemSubGroupID { get; set; }
        public string Name { get; set; }
        public int ItemSuperTypeID { get; set; }
        public ItemSuperType ItemSuperType { get; set; }
        public List<ItemType> ItemTypes { get; set; } = new List<ItemType>();
    }
}
