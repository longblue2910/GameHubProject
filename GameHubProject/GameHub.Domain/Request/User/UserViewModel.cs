using System;
using System.Collections.Generic;
using System.Text;

namespace GameHub.Domain.Request.User
{
    public class UserViewModel
    {
        public string Id { get; set; }

        public string FullName { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public string Gender { get; set; }

        public string DoB { get; set; }

        public string Company { get; set; }

        public string Facebook { get; set; }

        public string ImagePath { get; set; }

        public bool IsDelete { get; set; }

        public string Roles { get; set; }
    }
}
