using GameHub.Domain.Request.Post;
using GameHub.Domain.Response.Post;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.BAL.Interface
{
    public interface IVoteServices
    {
        Task<VoteRes> SaveVote(SaveVote request);
        Task<VoteRes> Delete(int id);
        Task<CheckRes> Check(CheckRate request);
    }
}
