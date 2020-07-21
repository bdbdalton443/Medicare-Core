using DemoHms;
using DemoHms.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AweCoreDemo.Data
{
    public class StockRoutine:BaseEntity
    {
        [Key]
        public int StockRoutineID { get; internal set; }
        public int? Quantity { get; internal set; }

       [DisplayName("Item")]
        public int? ItemID { get; internal set; }
        [ForeignKey("ItemID")]
        public Item Item { get; set; }

        [DisplayName("Stock")]
        public int? StockID { get; internal set; }
        [ForeignKey("StockID")]
        public Stok Stock { get; set; }

        [DisplayName("Procedure")]
        public int? ProcedureID { get; internal set; }
        [ForeignKey("ProcedureID")]
        public Procedure Procedure { get; set; }

        [DisplayName("TestConsumable")]
        public int? TestConsumableID { get; internal set; }
        [ForeignKey("TestConsumableID")]
        public TestConsumable TestConsumable { get; set; }

        [DisplayName("Treatment")]
        public int? TreatmentID { get; internal set; }
        [ForeignKey("TreatmentID")]
        public Treatment Treatment { get; set; }

        [DisplayName("Examination")]
        public int? ExaminationID { get; internal set; }
        [ForeignKey("ExaminationID")]
        public Examination Examination { get; set; }

        [DisplayName("Routine Type")]
        public int? RoutineTypeID { get; internal set; }
        [ForeignKey("RoutineTypeID")]
        public RoutineType RoutineType { get; set; }

    }
}
