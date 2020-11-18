using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameHub.API.Models.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }

        public string Address { get; set; }

        public string Gender { get; set; }

        public string DoB { get; set; }

        public string Company { get; set; }

        public string Facebook { get; set; }

        public string ImagePath { get; set; }
    }
}
