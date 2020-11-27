using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameHub.BAL.Interface;
using GameHub.DAL.Interface;
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
        private readonly IVoteServices voteServices;

        public PostController(ICommentService commentService, IVoteServices voteServices)
        {
            this.commentService = commentService;
            this.voteServices = voteServices;
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
        [HttpPost("Vote")]
        public async Task<OkObjectResult> Vote(SaveVote model)
        {
            var result = await voteServices.SaveVote(model);
            return Ok(result);
        }
        [HttpPatch("deletevote/{VoteId}")]
        public async Task<OkObjectResult> DeleteVote(int VoteId)
        {
            var result = await voteServices.Delete(VoteId);
            return Ok(result);
        }
        [HttpGet("CheckRate/{GameId}/{UserId}")]
        public async Task<OkObjectResult> CheckRate(int GameId,string UserId)
        {
            var request = new CheckRate()
            {
                UserId = UserId,
                GameId = GameId
            };
            var result = await voteServices.Check(request);
            return Ok(result);
        }
    }
}
