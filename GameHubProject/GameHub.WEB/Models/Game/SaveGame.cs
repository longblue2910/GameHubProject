using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameHub.WEB.Models.Game
{
    public class SaveGame
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public string[] Categorys { get; set; }
        public IFormFile[] Images { get; set; }
        public int BrandId { get; set; }
        public string Description { get; set; }
        public string UserId { get; set; }
    }
}
