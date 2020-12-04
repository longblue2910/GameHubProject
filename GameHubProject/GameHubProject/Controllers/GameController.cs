using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameHub.BAL.Interface;
using GameHub.Domain.Request.Game;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GameHub.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly IGameService gameService;

        public GameController(IGameService gameService)
        {
            this.gameService = gameService;
        }
        [HttpPost, HttpPatch]
        [Route("save")]
        public async Task<OkObjectResult> Save(SaveGameReq request)
        {
            var result = await gameService.Save(request);
            return Ok(result);
        }
        [HttpGet("gets")]
        public async Task<OkObjectResult> Gets()
        {
            var result = await gameService.Gets();
            return Ok(result);
        }
        [HttpGet("get/{id}")]
        public async Task<OkObjectResult> Get(int id)
        {
            var result = await gameService.Get(id);
            return Ok(result);
        }
        [HttpPatch("delete/{id}")]
        public async Task<OkObjectResult> Delete(int id)
        {
            var result = await gameService.Delete(id);
            return Ok(result);
        }
        [HttpGet("getbycategory/{id}")]
        public async Task<OkObjectResult> GetByCategory(int id)
        {
            var result = await gameService.GetByCategoryId(id);
            return Ok(result);
        }
        [HttpGet("getbybrand/{id}")]
        public async Task<OkObjectResult> GetByBrand(int id)
        {
            var result = await gameService.GetByBrandId(id);
            return Ok(result);
        }
        [HttpPatch("increaseDowloadGame/{id}")]
        public async Task<OkObjectResult> increaseDowloadGame(int id)
        {
            var result = await gameService.increaseDowloadGame(id);
            return Ok(result);
        }
        [HttpPatch("increaseViewGame/{id}")]
        public async Task<OkObjectResult> increaseViewGame(int id)
        {
            var result = await gameService.increaseViewGame(id);
            return Ok(result);
        }
        [HttpGet("getsbysearchword/{SearchWord}")]
        public async Task<OkObjectResult> GetBySearchWord(string SearchWord)
        {
            var result = await gameService.GetBySearchWord(SearchWord);
            return Ok(result);
        }
    }
}
