using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameHub.WEB.Models.Post
{
    public class SaveVote
    {
        public int VoteId { get; set; }
        public string UserId { get; set; }
        public int GameId { get; set; }
        public int vote { get; set; }
    }
}
