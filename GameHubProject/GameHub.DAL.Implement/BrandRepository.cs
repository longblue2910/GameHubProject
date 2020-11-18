using Dapper;
using GameHub.DAL.Interface;
using GameHub.Domain.Request.Brand;
using GameHub.Domain.Response.Brand;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.DAL.Implement
{
    public class BrandRepository : BaseRepository, IBrandRepository
    {
        public async Task<BrandRes> Delete(int id)
        {
            var result = new BrandRes()
            {
                BrandId = 0,
                Message = "Something went wrong, please contact administrator."
            };
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@BrandId", id);
                result = await SqlMapper.QueryFirstOrDefaultAsync<BrandRes>(cnn: connection,sql: "sp_DeleteBrand", param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                return result;
            }
        }

        public async Task<BrandView> Get(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@BrandId", id);
            var result = await SqlMapper.QueryFirstAsync<BrandView>(cnn: connection, sql: "sp_GetBrand", 
                                                                param: parameters, commandType: CommandType.StoredProcedure);
            return result;
        }

        public async Task<IEnumerable<BrandView>> Gets()
        {
            return await SqlMapper.QueryAsync<BrandView>(connection, "sp_GetsBrand", CommandType.StoredProcedure);
        }

        public async Task<BrandRes> save(SaveBrandReq request)
        {
            var result = new BrandRes()
            {
                BrandId = 0,
                Message = "Something went wrong, please contact administrator."
            };
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@BrandId", request.BrandId);
                parameters.Add("@BrandName", request.BrandName);
                result = await SqlMapper.QueryFirstOrDefaultAsync<BrandRes>(cnn: connection, sql: "sp_SaveBrand", param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                return result;
            }
        }
    }
}
