using Dapper;
using GameHub.DAL.Interface;
using GameHub.Domain.Request.Reply;
using GameHub.Domain.Response.Reply;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.DAL.Implement
{
    public class ReplyRepository : BaseRepository, IReplyRepository
    {
        public async Task<ReplyRes> Delete(int id)
        {
            var result = new ReplyRes()
            {
                RepId = 0,
                Message = "Something went wrong, please contact administrator."
            };
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ReplyId", id);
                result = await SqlMapper.QueryFirstOrDefaultAsync<ReplyRes>(cnn: connection, sql: "sp_DeleteRep", param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                return result;
            }
        }

        public async Task<IEnumerable<ReplyView>> GetsReply(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@CommentId", id);
            var result = await SqlMapper.QueryAsync<ReplyView>(cnn: connection, sql: "sp_GetsRepComment",
                                                                param: parameters, commandType: CommandType.StoredProcedure);
            return result;
        }

        public async Task<ReplyRes> Save(SaveReplyReq request)
        {
            var result = new ReplyRes()
            {
                RepId = 0,
                Message = "Something went wrong, please contact administrator."
            };
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@RepId", request.RepId);
                parameters.Add("@CommentId", request.CommentId);
                parameters.Add("@Text", request.Text);
                parameters.Add("@GameId", request.GameId);
                parameters.Add("@UserId", request.UserId);
                result = await SqlMapper.QueryFirstOrDefaultAsync<ReplyRes>(cnn: connection, sql: "sp_SaveReply", param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                return result;
            }
        }
    }
}
