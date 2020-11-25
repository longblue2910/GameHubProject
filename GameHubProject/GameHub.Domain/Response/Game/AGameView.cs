using System;
using System.Collections.Generic;
using System.Text;

namespace GameHub.Domain.Response.Game
{
    public class AGameView
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public string Categorys { get; set; }
        public int BrandId { get; set; }
        public string PathImage { get; set; }
        public string Desciption { get; set; }
        public string UserId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifieDate { get; set; }
        public string UserModified { get; set; }
        public int Download { get; set; }
        public string StatusName { get; set; }
        public bool IsDeleted { get; set; }
    }
}
