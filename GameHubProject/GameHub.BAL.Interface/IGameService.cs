using GameHub.Domain.Request.Game;
using GameHub.Domain.Response.Game;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.BAL.Interface
{
    public interface IGameService
    {
        Task<GameRes> Save(SaveGameReq request);
        Task<GameView> Get(int id);
        Task<IEnumerable<GameView>> GetByCategoryId(int categoryId);
        Task<IEnumerable<GameView>> GetByBrandId(int brandId);
        Task<IEnumerable<GameView>> Gets();
        Task<GameRes> Delete(int id);
        Task<GameRes> increaseViewGame(int id);
        Task<GameRes> increaseDowloadGame(int id);
        Task<IEnumerable<GameView>> GetBySearchWord(string SearchWord);
    }
}
