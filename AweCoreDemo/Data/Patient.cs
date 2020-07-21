using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoHms.Data
{
    public class Patient:BaseEntity
    {
        private int _patientID;
        string _firstName, _middleName, _lastName, _gender, _cardNO, _state, _address, tel, _occupation, _country, accNumber, email, city, destination;
        [Key]
        public int PatientID { get => _patientID; set => _patientID = value; }
        [NotMapped]
        public string FullName { get { return FirstName + " " + LastName; } }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string MiddleName { get => _middleName; set => _middleName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string Gender { get => _gender; set => _gender = value; }
        public string CardNO { get => _cardNO; set => _cardNO = value; }
        public string State { get => _state; set => _state = value; }
        public string Address { get => _address; set => _address = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Occupation { get => _occupation; set => _occupation = value; }
        public string Country { get => _country; set => _country = value; }
        public string AccNumber { get => accNumber; set => accNumber = value; }
        public string Email { get => email; set => email = value; }
        public string City { get => city; set => city = value; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DOB { get; set; }
        [Display(Name = "Patient Type")]
        public int? PatientTypeID { get; set; }

        [ForeignKey("PatientTypeID")]
        public PatientType PatientType { get; set; }
        [Display(Name = "Next Of Kin")]
        public int? NextOfKinID { get; set; }
        [ForeignKey("NextOfKinID")]
        public NextOfKin NextOfKin { get; set; }
        [Display(Name = "Family")]
        public int? FamilyID { get; set; }

        [ForeignKey("FamilyID")]
        public Family Family { get; set; }
        [Display(Name = "Organization")]
        public int? OrganisationID { get; set; }

        [ForeignKey("OrganisationID")]
        public Organisation Organisation { get; set; }
        public string ArmyNumber { get; set; }
        [Display(Name = "Army Unit")]
        public int? ArmyUnitID { get; set; }
        [ForeignKey("ArmyUnitID")]
        public ArmyUnit ArmyUnit { get; set; }

        [Display(Name = "Service Code")]
        public int? ServiceCodeID { get; set; }
        [ForeignKey("ServiceCodeID")]
        public ArmyService ArmyService { get; set; }
        [Display(Name = "Army Rank")]
        public int? RankID { get; set; }
        [ForeignKey("RankID")]
        public Rank Rank { get; set; }
        [Display(Name = "Army Status")]
        public int? ArmyStatusID { get; set; }
        [ForeignKey("ArmyStatusID")]
        public ArmyStatus ArmyStatus { get; set; }

        [Display(Name = "Hospital")]
        public int? HospitalID { get; set; }
        [ForeignKey("HospitalID")]
        public Hospital Hospital { get; set; }
        public List<Assignment> Assignments { get; set; } = new List<Assignment>();
        public List<Bill> Bills { get; set; } = new List<Bill>();
    }
}
