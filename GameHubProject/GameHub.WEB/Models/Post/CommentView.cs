using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameHub.WEB.Models.Post
{
    public class CommentView
    {
        public int CommentId { get; set; }
        public string Text { get; set; }
        public DateTime Time { get; set; }
        public int GameId { get; set; }
        public string Avatar { get; set; }
        public string UserName { get; set; }
        public string UserId { get; set; }
        public string StatusName { get; set; }
    }
}
