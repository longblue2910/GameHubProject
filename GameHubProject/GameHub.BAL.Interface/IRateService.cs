using GameHub.Domain.Request.Rate;
using GameHub.Domain.Response.Rate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.BAL.Interface
{
    public interface IRateService
    {
        Task<RateRes> Save(SaveRateReq request);
        Task<RateView> Get(int id);
        Task<RateRes> Delete(int id);
    }
}
