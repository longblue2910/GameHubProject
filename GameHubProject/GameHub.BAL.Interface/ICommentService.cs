using GameHub.Domain.Request.Comment;
using GameHub.Domain.Response.Comment;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.BAL.Interface
{
    public interface ICommentService
    {
        Task<CommentRes> Save(SaveCommentReq request);
        Task<IEnumerable<CommentView>> GetsCommentbyGameId(int id);
        Task<CommentRes> Delete(int id);
    }
}
