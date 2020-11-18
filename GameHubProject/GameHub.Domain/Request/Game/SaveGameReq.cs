using System;
using System.Collections.Generic;
using System.Text;

namespace GameHub.Domain.Request.Game
{
    public class SaveGameReq
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public string Description { get; set; }
        public string UserId { get; set; }
    }
}
