using GameHub.BAL.Interface;
using GameHub.DAL.Interface;
using GameHub.Domain.Request.Reply;
using GameHub.Domain.Response.Reply;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.BAL.Implement
{
    public class ReplyService : IReplyService
    {
        private readonly IReplyRepository replyRepository;

        public ReplyService(IReplyRepository replyRepository)
        {
            this.replyRepository = replyRepository;
        }
        public async Task<ReplyRes> Delete(int id)
        {
            return await replyRepository.Delete(id);
        }

        public async Task<IEnumerable<ReplyView>> GetsReply(int id)
        {
            return await replyRepository.GetsReply(id);
        }

        public async Task<ReplyRes> Save(SaveReplyReq request)
        {
            return await replyRepository.Save(request);
        }
    }
}
