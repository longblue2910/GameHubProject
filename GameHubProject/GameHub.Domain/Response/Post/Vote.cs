using System;
using System.Collections.Generic;
using System.Text;

namespace GameHub.Domain.Response.Post
{
    public class Vote
    {
        public int VoteId { get; set; }
        public string UserId { get; set; }
        public int GameId { get; set; }
        public int vote { get; set; }
    }
}
