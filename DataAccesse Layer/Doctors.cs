﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;



namespace DataAccesse_Layer
{
    public class Doctors
    {
       
        public string DoctorsName { get; set; }
        public long DoctorsID { get; set; }
        public long PassoutYear { get; set; }
        public string Qualification { get; set; }
        public long PhoneNumber { get; set; }
        public string Addresss { get; set; }
    }
}
