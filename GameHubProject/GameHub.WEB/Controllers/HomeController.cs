using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GameHub.WEB.Models;
using GameHub.WEB.Ultilities;
using GameHub.WEB.Models.Game;
using X.PagedList;
using Microsoft.AspNetCore.Http;

namespace GameHub.WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var user = User.Identity.Name;
            var userid = HttpContext.Session.GetString("Id");
            return View();
        }
        public IActionResult Details(int id)
        {
            ApiHelper<GameResult>.HttpPatchAsync($"Game/increaseViewGame/{id}", null);
            var game = ApiHelper<GameView>.HttpGetAsync($"game/get/{id}");
             return View(game);
        }
        public IActionResult AllGame(int? page)
        {
            int pageSize = 12;
            int pageNumber = (page ?? 1);
            var games = ApiHelper<List<GameView>>.HttpGetAsync($"game/gets");
            return View(games.ToPagedList(pageNumber, pageSize));
        }
        public IActionResult Search(string searchWord, int? page)
        {
            int pageSize = 12;
            int pageNumber = (page ?? 1);
            var games = ApiHelper<List<GameView>>.HttpGetAsync($"game/getsbysearchword/{searchWord}");
            ViewBag.SearchWord = searchWord;
            return View(games.ToPagedList(pageNumber, pageSize));
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Donate()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult ListCategory(int id, int? page)
        {
            int pageSize = 12;
            int pageNumber = (page ?? 1);
            var games = ApiHelper<List<GameView>>.HttpGetAsync($"game/getbycategory/{id}");
            return View(games.ToPagedList(pageNumber, pageSize));
        }
        public IActionResult ListBrand(int id, int? page)
        {
            int pageSize = 12;
            int pageNumber = (page ?? 1);
            var games = ApiHelper<List<GameView>>.HttpGetAsync($"game/getbycategory/{id}");
            return View(games.ToPagedList(pageNumber, pageSize));
        }
    }
}
