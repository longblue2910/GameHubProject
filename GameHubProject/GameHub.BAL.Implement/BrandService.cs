using GameHub.BAL.Interface;
using GameHub.DAL.Interface;
using GameHub.Domain.Request.Brand;
using GameHub.Domain.Response.Brand;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.BAL.Implement
{
    public class BrandService : IBrandService
    {
        private readonly IBrandRepository brandRepository;

        public BrandService(IBrandRepository brandRepository)
        {
            this.brandRepository = brandRepository;
        }
        public async Task<BrandRes> Delete(int id)
        {
            return await brandRepository.Delete(id);
        }

        public async Task<BrandView> Get(int id)
        {
            return await brandRepository.Get(id);
        }

        public async Task<IEnumerable<BrandView>> Gets()
        {
            return await brandRepository.Gets();
        }

        public async Task<BrandRes> save(SaveBrandReq request)
        {
            return await brandRepository.save(request);
        }
    }
}
