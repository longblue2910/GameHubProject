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
        [HttpGet("showRep/{id}")]
        public async Task<OkObjectResult> Show(int id)
        {
            var result = await replyService.Gets(id);
            return Ok(result);
        }
        [HttpGet("showARep/{id}")]
        public async Task<OkObjectResult> ShowAComment(int id)
        {
            var result = await replyService.Get(id);
            return Ok(result);
        }
        [HttpPost("PostRep")]
        public async Task<OkObjectResult> Post(SaveRep model)
        {
            var result = await replyService.SaveComment(model);
            return Ok(result);
        }
        [HttpPatch("delete/{RepId}")]
        public async Task<OkObjectResult> Delete(int RepId)
        {
            var result = await replyService.Delete(RepId);
            return Ok(result);
        }
    }
}
