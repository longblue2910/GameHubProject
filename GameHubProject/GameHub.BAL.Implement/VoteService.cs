using GameHub.BAL.Interface;
using GameHub.DAL.Interface;
using GameHub.Domain.Request.Post;
using GameHub.Domain.Response.Post;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.BAL.Implement
{
    public class VoteService : IVoteServices
    {
        private readonly IVoteRepository voteRepository;

        public VoteService(IVoteRepository voteRepository)
        {
            this.voteRepository = voteRepository;
        }

        public async Task<CheckRes> Check(CheckRate request)
        {
            return await voteRepository.Check(request);
        }

        public async Task<VoteRes> Delete(int id)
        {
            return await voteRepository.Delete(id);
        }

        public async Task<VoteRes> SaveVote(SaveVote request)
        {
            return await voteRepository.SaveVote(request);
        }
    }
}
