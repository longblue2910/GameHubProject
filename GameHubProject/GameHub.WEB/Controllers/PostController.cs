using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameHub.WEB.Models.Post;
using GameHub.WEB.Ultilities;
using Microsoft.AspNetCore.Mvc;

namespace GameHub.WEB.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("/Post/Gets/{GameId}")]
        public JsonResult Gets(int GameId)
        {
            List<CommentView> result = ApiHelper<List<CommentView>>.HttpGetAsync($"Post/showComment/{GameId}");
            return Json(new { result });
        }
        [HttpPost("/Post/save")]
        public JsonResult Save(SaveComment request)
        {
            var result = ApiHelper<CommentResult>.HttpPostAsync($"Post/PostComment", "POST", request);
            return Json(new { data = result });
        }
        [HttpPost]
        [Route("/Post/delete/{id}")]
        public IActionResult Delete(int CommentId)
        {
            var result = ApiHelper<CommentResult>.HttpPatchAsync($"Post/delete/{CommentId}", null);
            return Json(new { data = result });
        }
        [HttpPost("/Rate/saveVote")]
        public JsonResult SaveVote(SaveVote request)
        {
            var result = ApiHelper<VoteRes>.HttpPostAsync($"Post/Vote", "POST", request);
            return Json(new { data = result });
        }
        [HttpPost]
        [Route("/Rate/deleteVote/{id}")]
        public IActionResult DeleteVote(int CommentId)
        {
            var result = ApiHelper<VoteRes>.HttpPatchAsync($"Post/deletevote/{CommentId}", null);
            return Json(new { data = result });
        }
        [HttpGet("/Post/CheckVote/{GameId}/{UserId}")]
        public JsonResult CheckVote(int GameId, string UserId)
        {
            var result = ApiHelper<CheckRes>.HttpGetAsync($"Post/CheckRate/{GameId}/{UserId}");
            return Json(new { result });
        }
    }
}
