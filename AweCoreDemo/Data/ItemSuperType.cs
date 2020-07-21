using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoHms
{
    public class ItemSuperType
    {
        [Key]
        public int ItemSuperTypeID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public List<ItemSubGroup> ItemSubGroups { get; set; } = new List<ItemSubGroup>();
    }
}
