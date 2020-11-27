using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameHub.BAL.Interface;
using GameHub.Domain.Request.Post;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GameHub.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly ICommentService commentService;

        public PostController(ICommentService commentService)
        {
            this.commentService = commentService;
        }
        [HttpGet("showComment/{id}")]
        public async Task<OkObjectResult> Show(int id)
        {
            var result = await commentService.Gets(id);
            return Ok(result);
        }
        [HttpPost("PostComment")]
        public async Task<OkObjectResult> Post(SaveComment model)
        {
            var result = await commentService.SaveComment(model);
            return Ok(result);
        }
        [HttpPatch("delete/{CommentId}")]
        public async Task<OkObjectResult> Delete(int CommentId)
        {
            var result = await commentService.Delete(CommentId);
            return Ok(result);
        }
    }
}
