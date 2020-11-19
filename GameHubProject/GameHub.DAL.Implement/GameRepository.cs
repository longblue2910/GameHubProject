using Dapper;
using GameHub.DAL.Interface;
using GameHub.Domain.Request.Game;
using GameHub.Domain.Response.Game;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.DAL.Implement
{
    public class GameRepository : BaseRepository, IGameRepository
    {
        public async Task<GameRes> Delete(int id)
        {
            var result = new GameRes()
            {
                GameId = 0,
                Message = "Something went wrong, please contact administrator."
            };
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@GameId", id);
                result = await SqlMapper.QueryFirstOrDefaultAsync<GameRes>(cnn: connection, sql: "sp_DeleteBrand", param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                return result;
            }
        }

        public async Task<GameView> Get(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@GameId", id);
            var result = await SqlMapper.QueryFirstAsync<GameView>(cnn: connection, sql: "sp_GetGame",
                                                                param: parameters, commandType: CommandType.StoredProcedure);
            return result;
        }

        public async Task<GameView> GetByBrandId(int brandId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@BrandId", brandId);
            var result = await SqlMapper.QueryFirstAsync<GameView>(cnn: connection, sql: "sp_GetsGameByBrand",
                                                                param: parameters, commandType: CommandType.StoredProcedure);
            return result;
        }

        public async Task<GameView> GetByCategoryId(int categoryId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@CategoryId", categoryId);
            var result = await SqlMapper.QueryFirstAsync<GameView>(cnn: connection, sql: "sp_GetsGameByCategory",
                                                                param: parameters, commandType: CommandType.StoredProcedure);
            return result;
        }

        public async Task<IEnumerable<GameView>> Gets()
        {
            return await SqlMapper.QueryAsync<GameView>(connection, "sp_GetsGame", CommandType.StoredProcedure);
        }

        public async Task<GameRes> Save(SaveGameReq request)
        {
            var result = new GameRes()
            {
                GameId = 0,
                Message = "Something went wrong, please contact administrator."
            };
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@GameId", request.GameId);
                parameters.Add("@GameName", request.GameName);
                parameters.Add("@CategoryId", request.CategoryId);
                parameters.Add("@BrandId", request.BrandId);
                parameters.Add("@Desciption", request.Description);
                parameters.Add("@UserId", request.UserId);
                result = await SqlMapper.QueryFirstOrDefaultAsync<GameRes>(cnn: connection, sql: "sp_SaveGame", param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                return result;
            }
        }
    }
}
