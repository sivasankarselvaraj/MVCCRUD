using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAccesse_Layer
{
    public class Doctors
    {
        public long DoctorsID { get; set; }
        [Required(ErrorMessage = "Enter the Name ")]
        [RegularExpression("([A-Za-z])+( [A-Za-z]{1})", ErrorMessage = "Enter valid full name.")]
        public string DoctorsName { get; set; }
        [Required(ErrorMessage = "Enter the Qualificatoin ")]
        public string Qualification { get; set; }

        [Required(ErrorMessage = "Enter the Passout year ")]
        [DisplayName("PassYear")]
        [RegularExpression("([0-9]{4})",
         ErrorMessage = "Enter the Valid Passout Year.")]
        public long PassoutYear { get; set; }
       
        [Required(ErrorMessage = "Enter the PhoneNumber ")]
        [RegularExpression("[0-9]{10}",
         ErrorMessage = "Entered phone format is not valid.")]
        public long PhoneNumber { get; set; }
        [Required(ErrorMessage = "Enter the Address ")]
        public string Addresss { get; set; }
        public long LocationId { get; set; }
        public List<Locations> Location { get; set; }
    }
}
