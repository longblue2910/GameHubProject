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
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository commentRepository;

        public CommentService(ICommentRepository commentRepository)
        {
            this.commentRepository = commentRepository;
        }
        public async Task<CommentRes> Delete(int CommentId)
        {
            return await commentRepository.Delete(CommentId);
        }

        public async Task<CommentView> Get(int CommentId)
        {
            return await commentRepository.Get(CommentId);
        }

        public async Task<IEnumerable<CommentView>> Gets(int GameId)
        {
            return await commentRepository.Gets(GameId);
        }

        public async Task<CommentRes> SaveComment(SaveComment request)
        {
            return await commentRepository.SaveComment(request);
        }
    }
}
