using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using GameHub.WEB.Models.Game;
using GameHub.WEB.Ultilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace GameHub.WEB.Controllers
{
    public class GameController : Controller
    {
        private readonly IWebHostEnvironment webHost;

        public GameController(IWebHostEnvironment webHost)
        {
            this.webHost = webHost;
        }
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult Gets()
        {
            List<GameView> result = ApiHelper<List<GameView>>.HttpGetAsync($"Game/gets");
            return Json(new { result });
        }
        [HttpGet("/Game/getbycategory/{id}")]
        public JsonResult Getbycategory(int id)
        {
            List<GameView> result = ApiHelper<List<GameView>>.HttpGetAsync($"Game/getbycategory/{id}");
            return Json(new { result });
        }
        [HttpGet]
        public IActionResult Save()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Save(SaveGame request)
        {
            var game = new GameCreate()
            {
                BrandId = request.BrandId,
                Description = request.Description,
                GameId = request.GameId,
                GameName = request.GameName,
                UserId = request.UserId
            };
            game.Categorys = string.Join(",", request.Categorys);
            
            game.Images = saveImg(request.Images, game.GameId);
            var result = ApiHelper<GameResult>.HttpPostAsync($"game/save", "POST", game);
            return RedirectToAction("index","Game");
        }
        [HttpPost("/game/saveImg")]
        public string saveImg(IFormFile[] ImageFiles, int id)
        {
            string imgs = "";
            if (ImageFiles != null)
            {
                var iamge = ImageFiles.ToList();
                string uploadFolder = Path.Combine(webHost.WebRootPath, "images");
               
                for (int i = 0; i < iamge.Count; i++)
                {
                    string fileName = $"{Guid.NewGuid()}_{iamge[i].FileName}";
                    if (id != 0)
                    {
                        string[] files = Directory.GetFiles(uploadFolder);
                        for (int k = 0; k < files.Length; k++)
                        {
                            var tam = files[k].Split("\\");
                            if (fileName == tam[tam.Length-1])
                                global::System.IO.File.Delete(files[k]);
                        }

                    }
                    var filePath = Path.Combine(uploadFolder, fileName);
                    using (var fs = new FileStream(filePath, FileMode.Create))
                    {
                        iamge[i].CopyTo(fs);
                    }
                    if(imgs == "")
                        imgs += fileName;
                    else
                        imgs += "%" + fileName;
                }
            }
            return imgs;
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
        public IActionResult Update(int id)
        {
            var game = ApiHelper<UpdateGame>.HttpGetAsync($"game/get/{id}");
            return View(game);
        }
        [HttpGet]
        [Route("/Game/getRate/{id}")]
        public IActionResult get(int id)
        {
            var game = ApiHelper<GameView>.HttpGetAsync($"game/get/{id}");
            return Ok(game);
        }
    }
}
