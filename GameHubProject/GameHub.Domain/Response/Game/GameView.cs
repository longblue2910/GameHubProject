using System;

namespace GameHub.Domain.Response.Game
{
    public class GameView
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public string Desciption { get; set; }
        public string UserId { get; set; }
        public DateTime CreateDate { get; set; }
        public string UserModified { get; set; }
        public int Download { get; set; }
        public bool IsDeleted { get; set; }
    }
}
