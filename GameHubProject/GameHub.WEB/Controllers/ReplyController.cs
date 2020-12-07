using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameHub.Domain.Request.Reply;
using GameHub.Domain.Response.Reply;
using GameHub.WEB.Ultilities;
using Microsoft.AspNetCore.Mvc;

namespace GameHub.WEB.Controllers
{
    public class ReplyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("/Reply/Gets/{CommentId}")]
        public JsonResult Gets(int CommentId)
        {
            List<ReplyView> result = ApiHelper<List<ReplyView>>.HttpGetAsync($"Reply/showRep/{CommentId}");
            return Json(new { result });
        }
        [HttpGet("/Reply/Get/{RepId}")]
        public JsonResult Get(int RepId)
        {
            var result = ApiHelper<ReplyView>.HttpGetAsync($"Reply/showARep/{RepId}");
            return Json(new { result });
        }
        [HttpPost("/Reply/save")]
        public JsonResult Save(SaveRep request)
        {
            var result = ApiHelper<ReplyRes>.HttpPostAsync($"Reply/PostRep", "POST", request);
            return Json(new { data = result });
        }
        [HttpPost("/Reply/delete/{RepId}")]
        public IActionResult Delete(int RepId)
        {
            var result = ApiHelper<ReplyRes>.HttpPatchAsync($"Reply/delete/{RepId}", null);
            return Json(new { data = result });
        }
    }
}
