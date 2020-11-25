using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameHub.WEB.Models.Game
{
    public class GameView
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public IEnumerable<Category> Categorys { get; set; }
        public string Categoryss { get; set; }
        public IEnumerable<Image> Images { get; set; }
        public string PathImage { get; set; }
        public int BrandId { get; set; }
        public string Desciption { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public DateTime CreateDate { get; set; }
        public string UserModified { get; set; }
        public int Download { get; set; }
        public string StatusName { get; set; }
        public bool IsDeleted { get; set; }
    }
}
