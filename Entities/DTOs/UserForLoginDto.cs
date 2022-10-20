﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class UserForLoginDto:IDto
    {
        [Required]
        public string Email { get; set; }
        [Required,MinLength(8)]
        public string Password { get; set; }
    }
}
