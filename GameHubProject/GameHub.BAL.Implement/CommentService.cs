using GameHub.BAL.Interface;
using GameHub.DAL.Interface;
using GameHub.Domain.Request.Comment;
using GameHub.Domain.Response.Comment;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.BAL.Implement
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository commentRepository;

        public CommentService(ICommentRepository commentRepository)
        {
            this.commentRepository = commentRepository;
        }
        public async Task<CommentRes> Delete(int id)
        {
            return await commentRepository.Delete(id);
        }

        public async Task<IEnumerable<CommentView>> GetsCommentbyGameId(int id)
        {
            return await commentRepository.GetsCommentbyGameId(id);
        }

        public async Task<CommentRes> Save(SaveCommentReq request)
        {
            return await commentRepository.Save(request);
        }
    }
}
