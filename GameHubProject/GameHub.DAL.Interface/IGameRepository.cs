using GameHub.Domain.Request.Game;
using GameHub.Domain.Response.Game;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameHub.DAL.Interface
{
    public interface IGameRepository
    {
        Task<GameRes> Save(SaveGameReq request);
        Task<GameView> Get(int id);
        Task<GameView> GetByCategoryId(int categoryId);
        Task<GameView> GetByBrandId(int brandId);
        Task<IEnumerable<GameView>> Gets();
        Task<GameRes> Delete(int id);
    }
}
