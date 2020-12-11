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
        public async Task<ReplyRes> Delete(int RepId)
        {
            return await replyRepository.Delete(RepId);
        }

        public async Task<ReplyView> Get(int RepId)
        {
            return await replyRepository.Get(RepId);
        }

        public async Task<IEnumerable<ReplyView>> Gets(int CommentId)
        {
            return await replyRepository.Gets(CommentId);
        }

        public async Task<ReplyRes> SaveComment(SaveRep request)
        {
            return await replyRepository.SaveComment(request);
        }
    }
}
