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
        Task<ReplyRes> Save(SaveReplyReq request);
        Task<IEnumerable<ReplyView>> GetsReply(int id);
        Task<ReplyRes> Delete(int id);
    }
}
