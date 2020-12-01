﻿using GameHub.Domain.Common1;
using GameHub.Domain.Request.User;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.DAL.Interface
{
    public interface IUserRepository
    {
        Task<string> Authencate(LoginRequest request);
        Task<string> Register(RegisterRequest request);
        Task<bool> Update(string id, UserUpdateRequest request);
        Task<PagedResult<UserViewModel>> GetUserPaging(GetUserPagingRequest request);
        Task<UserViewModel> GetUserbyId(string id);
    }
}
