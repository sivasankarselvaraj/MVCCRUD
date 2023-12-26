using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;



namespace DataAccesse_Layer
{
    public class Doctors
    {
        [Required(ErrorMessage = "Enter the Name ")]
        public string DoctorsName { get; set; }
        public long DoctorsID { get; set; }
        [Required(ErrorMessage = "Enter the Passout year ")]
        [DisplayName(" PassYear")]
        public long PassoutYear { get; set; }
        [Required(ErrorMessage = "Enter the Qualificatoin ")]
        public string Qualification { get; set; }
        [Required(ErrorMessage = "Enter the PhoneNumber ")]
        public long PhoneNumber { get; set; }
        [Required(ErrorMessage = "Enter the Address ")]
        public string Addresss { get; set; }
    }
}
