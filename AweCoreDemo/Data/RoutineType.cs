using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AweCoreDemo.Data
{
    public class RoutineType
    {
        [Key]
        public int RoutineTypeID { get; internal set; }
        public string Name { get; set; }
        public List<StockRoutine> StockRoutines { get; set; } = new List<StockRoutine>();

    }
}
