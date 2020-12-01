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

        public async Task<IEnumerable<GameView>> GetBySearchWord(string SearchWord)
        {
            return await gameRepository.GetBySearchWord(SearchWord);
        }

        public async Task<IEnumerable<GameView>> Gets()
        {
            var result = await gameRepository.Gets();
            var tam =new List<GameView>();
            foreach(var item in result)
            {
                var dem = 0;
                if(tam.Count >= 1)
                {
                    foreach (var item1 in tam)
                    {
                        if (item.GameId == item1.GameId)
                        {
                            dem++;
                            break;
                        }
                    }
                    if(dem == 0)
                    {
                        item.Categorys = await gameRepository.GetsCategory(item.GameId);
                        foreach(var item2 in item.Categorys)
                        {
                            item.Categoryss += item2.CategoryName + ", ";
                        }
                        tam.Add(item);
                    }
                }
                else
                {
                    item.Categorys = await gameRepository.GetsCategory(item.GameId);
                    foreach (var item2 in item.Categorys)
                    {
                        item.Categoryss += item2.CategoryName + ", ";
                    }
                    tam.Add(item);
                }
                
            }
            return tam;
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
