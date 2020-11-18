using GameHub.Domain.Request.Brand;
using GameHub.Domain.Response.Brand;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.DAL.Interface
{
    public interface IBrandRepository
    {
        Task<BrandRes> save(SaveBrandReq request);
        Task<IEnumerable<BrandView>> Gets();
        Task<BrandView> Get(int id);
        Task<BrandRes> Delete(int id);
    }
}
