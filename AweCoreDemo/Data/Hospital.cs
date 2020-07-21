using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DemoHms.Data
{
    public class Hospital:BaseEntity
    {
        int statusID, contractLength, entityTypeID;
        string name, location, contactNumber, boxNumber, email;
        string color;
        Status _status;
        EntityType _entityType;
        [Key]
        public int HospitalID { get; set; }
        public string Name { get => name; set => name = value; }
        public string Location { get => location; set => location = value; }
        public string ContactNumber { get => contactNumber; set => contactNumber = value; }
        public string BoxNumber { get => boxNumber; set => boxNumber = value; }
        public string Email { get => email; set => email = value; }
        public int ContractLength { get => contractLength; set => contractLength = value; }
        public string Color { get => color; set => color = value; }

        [Display(Name="Status")]
        public int? StatusID { get => statusID; set => statusID = (int)value; }
        [ForeignKey("StatusID")]
        public Status Status { get => _status; set => _status = value; }
        [Display(Name = "Entity Type")]
        public int? EntityTypeID { get => entityTypeID; set => entityTypeID = (int)value; }
        [ForeignKey("EntityTypeID")]
        public EntityType EntityType { get => _entityType; set => _entityType = value; }
        public List<Branch> Branches { get; set; } = new List<Branch>();
        public List<Patient> Patients { get; set; } = new List<Patient>();
        public List<ApplicationUser> ApplicationUsers { get; set; } = new List<ApplicationUser>();
        public List<Mapping> Mappings { get; set; } = new List<Mapping>();
    }
}
