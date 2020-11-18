using Dapper;
using GameHub.DAL.Interface;
using GameHub.Domain.Request.Category;
using GameHub.Domain.Response.Category;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace GameHub.DAL.Implement
{
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public async Task<CategoryRes> Delete(int id)
        {
            var result = new CategoryRes()
            {
                CategoryId = 0,
                Message = "Something went wrong, please contact administrator."
            };
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@CategoryId", id);
                result = await SqlMapper.QueryFirstOrDefaultAsync<CategoryRes>(cnn: connection,
                                                                        sql: "sp_DeleteCategory",
                                                                        param: parameters,
                                                                        commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                return result;
            }
        }

        public async Task<CategoryView> Get(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@CategoryId", id);
            var result = await SqlMapper.QueryFirstAsync<CategoryView>(cnn: connection,
                                                                    sql: "sp_GetCategory",
                                                                    param: parameters,
                                                                    commandType: CommandType.StoredProcedure);
            return result;
        }

        public async Task<IEnumerable<CategoryView>> Gets()
        {
            DynamicParameters parameters = new DynamicParameters();
            var result = await SqlMapper.QueryAsync<CategoryView>(cnn: connection,
                                                                    sql: "sp_GetsCategory",
                                                                    commandType: CommandType.StoredProcedure);
            return result;
        }

        public async Task<CategoryRes> Save(SaveCategoryReq request)
        {
            var result = new CategoryRes()
            {
                CategoryId = 0,
                Message = "Something went wrong, please contact administrator."
            };
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@CategoryId", request.CategoryId);
                parameters.Add("@CategoryName", request.CategoryName);

                result = await SqlMapper.QueryFirstOrDefaultAsync<CategoryRes>(cnn: connection,
                                                                    sql: "sp_SaveCategory",
                                                                    param: parameters,
                                                                    commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {

                return result;
            }
        }
    }
}
