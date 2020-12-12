﻿using GameHub.Domain.Request.Category;
using GameHub.Domain.Response.Category;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameHub.BAL.Interface
{
    public interface ICategoryService
    {
        Task<CategoryRes> Save(SaveCategoryReq request);
        Task<CategoryView> Get(int id);
        Task<IEnumerable<CategoryView>> Gets();
        Task<CategoryRes> Delete(int id);
    }
}
