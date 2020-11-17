using GameHub.BAL.Interface;
using GameHub.DAL.Interface;
using GameHub.Domain.Request.Category;
using GameHub.Domain.Response.Category;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameHub.BAL.Implement
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public async Task<CategoryRes> Delete(int id)
        {
            return await categoryRepository.Delete(id);
        }

        public async Task<CategoryView> Get(int id)
        {
            return await categoryRepository.Get(id);
        }

        public async Task<IEnumerable<CategoryView>> Gets()
        {
            return await categoryRepository.Gets();
        }

        public async Task<CategoryRes> Save(SaveCategoryReq request)
        {
            var tam =  await categoryRepository.Save(request);
            return tam;
        }
    }
}
