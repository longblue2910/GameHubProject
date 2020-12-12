using System;
using System.Collections.Generic;
using System.Text;

namespace GameHub.Domain.Request.Post
{
    public class CheckRate
    {
        public int GameId { get; set; }
        public string UserId { get; set; }
    }
}
