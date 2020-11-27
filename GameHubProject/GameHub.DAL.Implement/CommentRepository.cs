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
    public class CommentRepository : BaseRepository, ICommentRepository
    {
        public async Task<CommentRes> Delete(int CommentId)
        {
            var result = new CommentRes()
            {
                CommentId = 0,
                Message = "Something went wrong, please contact administrator."
            };
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@CommentId", CommentId);
                result = await SqlMapper.QueryFirstOrDefaultAsync<CommentRes>(cnn: connection,
                                                                        sql: "sp_DeleteComment",
                                                                        param: parameters,
                                                                        commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                return result;
            }
        }

        public async Task<IEnumerable<CommentView>> Gets(int GameId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@GameId", GameId);
            var result = await SqlMapper.QueryAsync<CommentView>(cnn: connection,
                                                                    sql: "sp_GetsCommentByGameId",
                                                                    param: parameters,
                                                                    commandType: CommandType.StoredProcedure);
            return result;
        }

        public async Task<CommentRes> SaveComment(SaveComment request)
        {
            var result = new CommentRes()
            {
                CommentId = 0,
                Message = "Something went wrong, please contact administrator."
            };
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@CommentId", request.CommentId);
                parameters.Add("@Text", request.Text);
                parameters.Add("@GameId", request.GameId);
                parameters.Add("@UserId", request.UserId);
                result = await SqlMapper.QueryFirstOrDefaultAsync<CommentRes>(cnn: connection,
                                                                        sql: "sp_SaveComment",
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
