﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class UserForRegisterDto:IDto
    {

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
      
        public string Password { get; set; }
        //[Required(ErrorMessage="Re-enter the password"), MinLength(8),Compare(nameof(Password))]
        public string RePassword { get; set; }
        
    }
}
