using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoHms.Data
{
    public class Branch
    {
        private string  _name, _location;
        private int _hospitalID, _branchID, _branchTypeID;
        public int BranchID { get => _branchID; set => _branchID = value; }
        public string Name { get => _name; set => _name = value; }
        public string Location { get => _location; set => _location = value; }
        [Display(Name = "Hospital")]
        public int? HospitalID { get => _hospitalID; set => _hospitalID = (int)value; }
        [ForeignKey("HospitalD")]
        public Hospital Hospital { get; set; }
        public int? BranchTypeID { get => _branchTypeID; set => _branchTypeID = (int)value; }

        [ForeignKey("BranchTypeID")]
        public BranchType BranchType { get; set; }
        public List<Department> Departments { get; set; } = new List<Department>();
    }
}
