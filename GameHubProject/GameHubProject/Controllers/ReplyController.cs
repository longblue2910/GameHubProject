using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameHub.BAL.Interface;
using GameHub.Domain.Request.Reply;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GameHub.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReplyController : ControllerBase
    {
        private readonly IReplyService replyService;

        public ReplyController(IReplyService replyService)
        {
            this.replyService = replyService;
        }
        [HttpPost, HttpPatch]
        [Route("save")]
        public async Task<OkObjectResult> Save(SaveReplyReq request)
        {
            var result = await replyService.Save(request);
            return Ok(result);
        }
        [HttpPatch("delete/{id}")]
        public async Task<OkObjectResult> Delete(int id)
        {
            var result = await replyService.Delete(id);
            return Ok(result);
        }
        [HttpGet("gets/{id}")]
        public async Task<OkObjectResult> GetReply(int id)
        {
            var result = await replyService.GetsReply(id);
            return Ok(result);
        }
    }
}
