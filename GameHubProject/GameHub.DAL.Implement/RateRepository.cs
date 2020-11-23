using Dapper;
using GameHub.DAL.Interface;
using GameHub.Domain.Request.Rate;
using GameHub.Domain.Response.Rate;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.DAL.Implement
{
    public class RateRepository : BaseRepository, IRateRepository
    {
        public async Task<RateRes> Delete(int id)
        {
            var result = new RateRes()
            {
                RateId = 0,
                Message = "Something went wrong, please contact administrator."
            };
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@RateId", id);
                result = await SqlMapper.QueryFirstOrDefaultAsync<RateRes>(cnn: connection, sql: "sp_DeleteRate", param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                return result;
            }
        }

        public async Task<RateView> Get(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@CommentId", id);
            var result = await SqlMapper.QueryFirstAsync<RateView>(cnn: connection, sql: "sp_GetVote",
                                                                param: parameters, commandType: CommandType.StoredProcedure);
            return result;
        }

        public async Task<RateRes> Save(SaveRateReq request)
        {
            var result = new RateRes()
            {
                RateId = 0,
                Message = "Something went wrong, please contact administrator."
            };
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@RateId", request.RateId);
                parameters.Add("@Vote", request.Vote);
                parameters.Add("@GameId", request.GameId);
                parameters.Add("@UserId", request.UserId);
                result = await SqlMapper.QueryFirstOrDefaultAsync<RateRes>(cnn: connection, sql: "sp_SaveRate", param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                return result;
            }
        }
    }
}
