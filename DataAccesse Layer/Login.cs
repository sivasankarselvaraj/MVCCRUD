﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DataAccesse_Layer
{
    public class Login
    {
        [RegularExpression(" [a - zA - Z0 - 9 + _.-] +@[a-zA-Z0-9.-]",ErrorMessage ="Required")]
        public  string Email { get; set; }
        public string Password { get; set; }
    }
}
