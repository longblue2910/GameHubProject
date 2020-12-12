using GameHub.Domain.Request.Post;
using GameHub.Domain.Response.Post;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.BAL.Interface
{
    public interface ICommentService
    {
        Task<CommentRes> SaveComment(SaveComment request);
        Task<CommentRes> Delete(int CommentId);
        Task<IEnumerable<CommentView>> Gets(int GameId);
        Task<CommentView> Get(int CommentId);
    }
}
