using GameHub.BAL.Interface;
using GameHub.DAL.Interface;
using GameHub.Domain.Request.Rate;
using GameHub.Domain.Response.Rate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.BAL.Implement
{
    public class RateService : IRateService
    {
        private readonly IRateRepository rateRepository;

        public RateService(IRateRepository rateRepository)
        {
            this.rateRepository = rateRepository;
        }
        public async Task<RateRes> Delete(int id)
        {
            return await rateRepository.Delete(id);
        }

        public async Task<RateView> Get(int id)
        {
            return await rateRepository.Get(id);
        }

        public async Task<RateRes> Save(SaveRateReq request)
        {
            return await rateRepository.Save(request);
        }
    }
}
