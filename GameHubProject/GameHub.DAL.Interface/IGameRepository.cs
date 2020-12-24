using GameHub.Domain.Request.Game;
using GameHub.Domain.Response.Game;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameHub.DAL.Interface
{
    public interface IGameRepository
    {
        Task<GameRes> Save(SaveGameReq request);
        Task<GameRes> increaseViewGame(int id);
        Task<GameRes> increaseDowloadGame(int id);
        Task<GameView> Get(int id);
        Task<IEnumerable<Category>> GetsCategory(int id);
        Task<IEnumerable<Image>> GetsImage(int id);
        Task<IEnumerable<GameView>> GetByCategoryId(int categoryId);
        Task<IEnumerable<GameView>> GetByBrandId(int brandId);
        Task<IEnumerable<GameView>> GetBySearchWord(string SearchWord);
        Task<IEnumerable<GameView>> Gets();
        Task<IEnumerable<GameView>> TopViewGames();
        Task<GameRes> Delete(int id);
    }
}
