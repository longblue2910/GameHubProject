﻿using GameHub.Domain.Request.Game;
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
        Task<GameView> GetByCategoryId(int categoryId);
        Task<GameView> GetByBrandId(int brandId);
        Task<IEnumerable<GameView>> Gets();
        Task<GameRes> Delete(int id);
        Task<IEnumerable<GameView>> GetByCharacter(string searchword);
    }
}
