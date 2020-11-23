using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameHub.BAL.Interface;
using GameHub.Domain.Request.Comment;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GameHub.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentService commentService;

        public CommentController(ICommentService commentService)
        {
            this.commentService = commentService;
        }
        [HttpPost, HttpPatch]
        [Route("save")]
        public async Task<OkObjectResult> Save(SaveCommentReq request)
        {
            var result = await commentService.Save(request);
            return Ok(result);
        }
        [HttpPatch("delete/{id}")]
        public async Task<OkObjectResult> Delete(int id)
        {
            var result = await commentService.Delete(id);
            return Ok(result);
        }
        [HttpGet("getbyGameId/{id}")]
        public async Task<OkObjectResult> GetByGameid(int id)
        {
            var result = await commentService.GetsCommentbyGameId(id);
            return Ok(result);
        }
    }
}
