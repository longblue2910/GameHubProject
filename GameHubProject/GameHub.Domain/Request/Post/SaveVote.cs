using System;
using System.Collections.Generic;
using System.Text;

namespace GameHub.Domain.Request.Post
{
    public class SaveVote
    {
        public int VoteId { get; set; }
        public string UserId { get; set; }
        public int GmeId { get; set; }
        public int Vote { get; set; }
    }
}
