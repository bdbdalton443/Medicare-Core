using DemoHms;
using DemoHms.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AweCoreDemo.Data
{
    public class DispenseRoutine : BaseEntity
    {
        [Key]
        public int DispenseRoutineID { get; internal set; }
        public int? ItemID { get; internal set; }

        [ForeignKey("ItemID")]
        public Item Item { get; internal set; }
        public int? Quantity { get; internal set; }
        public int? PatientID { get; internal set; }

        [ForeignKey("PatientID")]
        public Patient Patient { get; internal set; }

        public int? TreatmentID { get; internal set; }
        [ForeignKey("TreatmentID")]
        public Treatment Treatment { get; internal set; }
    }
}
