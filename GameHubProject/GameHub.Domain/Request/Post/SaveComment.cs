using System;
using System.Collections.Generic;
using System.Text;

namespace GameHub.Domain.Request.Post
{
    public class SaveComment
    {
        public int CommentId { get; set; }
        public string Text { get; set; }
        public int GameId { get; set; }
        public string UserId { get; set; }
    }
}
