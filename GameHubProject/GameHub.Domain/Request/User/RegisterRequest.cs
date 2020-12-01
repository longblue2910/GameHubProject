using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GameHub.Domain.Request.User
{
    public class RegisterRequest
    {
        [Required]
        public DateTime DoB { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="ComfirmPassword not matched")]
        public string ConfirmPassword { get; set; }
    }
}
