using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameHub.BAL.Interface;
using GameHub.Domain.Request.Rate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GameHub.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RateController : ControllerBase
    {
        private readonly IRateService rateService;

        public RateController(IRateService rateService)
        {
            this.rateService = rateService;
        }
        [HttpPost, HttpPatch]
        [Route("save")]
        public async Task<OkObjectResult> Save(SaveRateReq request)
        {
            var result = await rateService.Save(request);
            return Ok(result);
        }
        [HttpPatch("delete/{id}")]
        public async Task<OkObjectResult> Delete(int id)
        {
            var result = await rateService.Delete(id);
            return Ok(result);
        }
        [HttpGet("get/{id}")]
        public async Task<OkObjectResult> Get(int id)
        {
            var result = await rateService.Get(id);
            return Ok(result);
        }
    }
}
