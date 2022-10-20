using Entities.Abstract;
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
        [Required]
        public string Email { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required, MinLength(8)]
        public string Password { get; set; }
        [Required(ErrorMessage="Re-enter the password"), MinLength(8),Compare(nameof(Password))]
        public string RePassword { get; set; }
        
    }
}
