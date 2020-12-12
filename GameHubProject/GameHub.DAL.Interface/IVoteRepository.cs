using GameHub.Domain.Request.Post;
using GameHub.Domain.Response.Post;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.DAL.Interface
{
    public interface IVoteRepository
    {
        Task<VoteRes> SaveVote(SaveVote request);
        Task<VoteRes> Delete(int id);
        Task<CheckRes> Check(CheckRate request);
    }
}
