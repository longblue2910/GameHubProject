using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameHub.WEB.Models.Game;
using GameHub.WEB.Ultilities;
using Microsoft.AspNetCore.Mvc;

namespace GameHub.WEB.Controllers
{
    public class GameController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult Gets()
        {
            List<GameView> result = ApiHelper<List<GameView>>.HttpGetAsync($"Game/gets");
            return Json(new { result });
        }
        [HttpPost]
        [Route("/game/save")]
        public JsonResult Save([FromBody] SaveGameReq request)
        {
            var result = ApiHelper<GameResult>.HttpPostAsync($"game/save", "POST", request);
            return Json(new { data = result });
        }
        [HttpPost]
        [Route("/game/delete/{id}")]
        public IActionResult Delete(int id)
        {
            var result = ApiHelper<GameResult>.HttpPatchAsync($"Game/Delete/{id}", null);
            return Json(new { data = result });
        }
        [HttpGet]
        [Route("/Game/get/{id}")]
        public JsonResult Get(int id)
        {
            var game = ApiHelper<GameView>.HttpGetAsync($"game/get/{id}");
            return Json(new { data = game });
        }
    }
}
