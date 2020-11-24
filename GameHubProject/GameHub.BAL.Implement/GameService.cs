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
            return await gameRepository.Get(id);
        }

        public async Task<GameView> GetByBrandId(int brandId)
        {
            return await gameRepository.GetByBrandId(brandId);
        }

        public async Task<GameView> GetByCategoryId(int categoryId)
        {
            return await gameRepository.GetByCategoryId(categoryId);
        }

        public async Task<IEnumerable<GameView>> Gets()
        {
            return await gameRepository.Gets();
        }

        public async Task<GameRes> Save(SaveGameReq request)
        {
            return await gameRepository.Save(request);
        }
    }
}
