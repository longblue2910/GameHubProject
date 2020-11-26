﻿using GameHub.Domain.Request.Post;
using GameHub.Domain.Response.Post;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.DAL.Interface
{
    public interface ICommentRepository
    {
        Task<CommentRes> SaveComment(SaveComment request);
        Task<CommentRes> Delete(int CommentId);
        Task<IEnumerable<CommentView>> Gets(int GameId);
    }
}
