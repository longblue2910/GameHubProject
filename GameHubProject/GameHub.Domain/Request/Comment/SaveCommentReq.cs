using System;
using System.Collections.Generic;
using System.Text;

namespace GameHub.Domain.Request.Comment
{
    public class SaveCommentReq
    {
        public int CommentId { get; set; }
        public string Text { get; set; }
        public int GameId { get; set; }
        public string UserId { get; set; }
    }
}
