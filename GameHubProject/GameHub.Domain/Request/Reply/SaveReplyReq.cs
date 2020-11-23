using System;
using System.Collections.Generic;
using System.Text;

namespace GameHub.Domain.Request.Reply
{
    public class SaveReplyReq
    {
        public int RepId { get; set; }
        public int CommentId { get; set; }
        public string Text { get; set; }
        public int GameId { get; set; }
        public string UserId { get; set; }
    }
}
