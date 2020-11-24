using GameHub.BAL.Interface;
using GameHub.DAL.Interface;
using GameHub.Domain.Request.Game;
using GameHub.Domain.Response.Game;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.BAL.Implement
{
    public class GameService : IGameService
    {
        private readonly IGameRepository gameRepository;

        public GameService(IGameRepository gameRepository)
        {
            this.gameRepository = gameRepository;
        }
        public async Task<GameRes> Delete(int id)
        {
            return await gameRepository.Delete(id);
        }

        public async Task<GameView> Get(int id)
        {
            var result = await gameRepository.Get(id);
            result.Images = await gameRepository.GetsImage(id);
            result.Categorys = await gameRepository.GetsCategory(id);
            return result;
        }

        public async Task<IEnumerable<GameView>> GetByBrandId(int brandId)
        {
            return await gameRepository.GetByBrandId(brandId);
        }

        public async Task<IEnumerable<GameView>> GetByCategoryId(int categoryId)
        {
            return await gameRepository.GetByCategoryId(categoryId);
        }

        public async Task<IEnumerable<GameView>> Gets()
        {
            return await gameRepository.Gets();
        }

        public async Task<GameRes> increaseDowloadGame(int id)
        {
            return await gameRepository.increaseDowloadGame(id);
        }

        public async Task<GameRes> increaseViewGame(int id)
        {
            return await gameRepository.increaseViewGame(id);
        }

        public async Task<GameRes> Save(SaveGameReq request)
        {
            return await gameRepository.Save(request);
        }
    }
}
