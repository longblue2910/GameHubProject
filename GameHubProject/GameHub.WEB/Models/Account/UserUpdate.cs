using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameHub.WEB.Models.Account
{
    public class UserUpdate
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string DoB { get; set; }

        public string Address { get; set; }

        public string Gender { get; set; }

        public string Company { get; set; }

        public string Facebook { get; set; }
        public string PhoneNumber { get; set; }

        public IFormFile ImagePath { get; set; }
        public List<string> Roles { get; set; }
    }
}
