using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoHms.Data
{
    public class NextOfKin:BaseEntity
    {
        private int _nextOfKinID;
        private string _firstName, _middleName, _lastName, _guid, _gender, _address, tel, _occupation, _country, email, city;
        [Key]
        public int NextOfKinID { get => _nextOfKinID; set => _nextOfKinID = value; }
        [NotMapped]
        public string FullName { get { return FirstName + " " + LastName; } }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string MiddleName { get => _middleName; set => _middleName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string Guid { get => _guid; set => _guid = value; }
        public string Gender { get => _gender; set => _gender = value; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DOB { get; set; }
        public string Address { get => _address; set => _address = value; }
        [Phone]
        public string Tel { get => tel; set => tel = value; }
        public string Occupation { get => _occupation; set => _occupation = value; }
        public string Country { get => _country; set => _country = value; }
        [EmailAddress]
        public string Email { get => email; set => email = value; }
        public string City { get => city; set => city = value; }
        [Display(Name = "NOK Relationship")]
        public int? NOKRelationshipID { get; set; }
        [ForeignKey("NOKRelationshipID")]
        public NOKRelationship NOKRelationship { get; set; }
        public List<Patient> Patients { get; set; } = new List<Patient>();
    }
}
