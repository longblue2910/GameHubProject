using GameHub.Domain.Request.Reply;
using GameHub.Domain.Response.Reply;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.BAL.Interface
{
    public interface IReplyService
    {
        Task<ReplyRes> SaveComment(SaveRep request);
        Task<ReplyRes> Delete(int RepId);
        Task<IEnumerable<ReplyView>> Gets(int CommentId);
        Task<ReplyView> Get(int RepId);
    }
}
