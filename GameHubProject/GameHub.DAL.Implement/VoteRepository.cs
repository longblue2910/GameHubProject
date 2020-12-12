using Dapper;
using GameHub.DAL.Interface;
using GameHub.Domain.Request.Post;
using GameHub.Domain.Response.Post;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.DAL.Implement
{
    public class VoteRepository : BaseRepository, IVoteRepository
    {
        public async Task<CheckRes> Check(CheckRate request)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@GameId", request.GameId);
            parameters.Add("@UserId", request.UserId);
            var result = await SqlMapper.QueryFirstOrDefaultAsync<CheckRes>(cnn: connection,
                                                                    sql: "sp_CheckRate",
                                                                    param: parameters,
                                                                    commandType: CommandType.StoredProcedure);
            return result;
        }

        public async Task<VoteRes> Delete(int id)
        {
            var result = new VoteRes()
            {
                VoteId = 0,
                Message = "Something went wrong, please contact administrator."
            };
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@RateId", id);
                result = await SqlMapper.QueryFirstOrDefaultAsync<VoteRes>(cnn: connection,
                                                                        sql: "sp_DeleteRate",
                                                                        param: parameters,
                                                                        commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                return result;
            }
        }

        public async Task<VoteRes> SaveVote(SaveVote request)
        {
            var result = new VoteRes()
            {
                VoteId = 0,
                Message = "Something went wrong, please contact administrator."
            };
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@RateId", request.VoteId);
                parameters.Add("@GameId", request.GameId);
                parameters.Add("@Vote", request.vote);
                parameters.Add("@UserId", request.UserId);
                result = await SqlMapper.QueryFirstOrDefaultAsync<VoteRes>(cnn: connection,
                                                                        sql: "sp_SaveRate",
                                                                        param: parameters,
                                                                        commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                return result;
            }
        }
    }
}
