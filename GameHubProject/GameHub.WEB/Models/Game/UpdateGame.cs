using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameHub.WEB.Models.Game
{
    public class UpdateGame
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public IEnumerable<Category> Categorys { get; set; }
        public IEnumerable<Image> Images { get; set; }
        public int BrandId { get; set; }
        public string PathImage { get; set; }
        public string Description { get; set; }
        public string UserId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifieDate { get; set; }
        public string UserModified { get; set; }
        public int Download { get; set; }
        public string StatusName { get; set; }
        public bool IsDeleted { get; set; }
        public int CountRate { get; set; }
        public float AvgRate { get; set; }
    }
}
