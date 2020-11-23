using System;
using System.Collections.Generic;
using System.Text;

namespace GameHub.Domain.Response.Comment
{
    public class CommentView
    {
        public string Text { get; set; }
        public DateTime Time { get; set; }
        public string UserName { get; set; }
        public string Avatar { get; set; }
        public string StatusName { get; set; }
    }
}
