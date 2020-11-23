using System;
using System.Collections.Generic;
using System.Text;

namespace GameHub.Domain.User
{
    public class AuthenticationResult
    {
        public string Error { get; set; }
        public bool Success { get; set; }
        public string Token { get; set; }
        public string RefreshToken { get; set; }
    }
}
