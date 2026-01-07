using Dapper;
using Kaira.WebUI.Context;
using Kaira.WebUI.DTOs.ProductDtos;
using Kaira.WebUI.DTOs.WearDtos;
using System.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Kaira.WebUI.Repositories.WearRepositories
{
    public class WearRepository(AppDbContext context) : IWearRepository
    {
        private readonly IDbConnection _db = context.CreateConnection();
        public async Task CreateAsync(CreateWearDto createDto)
        {
            var query = "Insert into Products (Name,ImageUrl,Description,Price,CategoryId,WearId,IsHome) values (@Name,@ImageUrl,@Description,@Price,@Categoryıd,@WearId,@IsHome";
            var parameters = new DynamicParameters(createDto);
            await _db.ExecuteAsync(query, parameters);
        }

        public async Task DeleteAsync(int id)
        {
            string query = "Delete From Products where WearId = @WearId";
            var parameters = new DynamicParameters();
            parameters.Add("WearId", id);
            await _db.ExecuteAsync(query, parameters);
        }

        public async Task<IEnumerable<ResultWearDto>> GetAllAsync()
        {
            var query = @"
                        SELECT 
                            w.*,
                            c.Name AS CategoryName
                        FROM Wears w
                        INNER JOIN Categories c 
                            ON c.CategoryId = w.CategoryId
                    ";

            return await _db.QueryAsync<ResultWearDto>(query);

        }

        public async Task<IEnumerable<ResultWearDto>> GetByCategoryIdAsync(int id)
        {
            var query = @"
                        SELECT 
                            w.*,
                            c.Name AS CategoryName,
                            c.ImageUrl AS CategoryImage
                        FROM Wears w
                        INNER JOIN Categories c 
                            ON c.CategoryId = w.CategoryId where w.CategoryId=@CategoryId";
            var parameters = new DynamicParameters();
            parameters.Add("CategoryId", id);
            return await _db.QueryAsync<ResultWearDto>(query,parameters);
        }

        public async Task<UpdateWearDto> GetByIdAsync(int id)
        {
            var query = @"
                        SELECT 
                            w.*,
                            c.Name AS CategoryName
                        FROM Wears w
                        INNER JOIN Categories c 
                            ON c.CategoryId = w.CategoryId where WearId=@WearId";
            var parameters = new DynamicParameters();
            parameters.Add("WearId", id);
            return await _db.QueryFirstOrDefaultAsync<UpdateWearDto>(query, parameters);
        }

        public async Task<IEnumerable<ResultWearDto>> GetCategoryByAllAsync()
        {
            var query = @"
                        SELECT 
                            w.*,
                            c.Name AS CategoryName,
                            c.ImageUrl AS CategoryImage
                        FROM Wears w
                        INNER JOIN Categories c 
                            ON c.CategoryId = w.CategoryId
                            ORDER BY c.Name,c.ImageUrl
                    ";

            return await _db.QueryAsync<ResultWearDto>(query);
        }

        public async Task<IEnumerable<ResultWearDto>> GetIsHomeAsync()
        {
            var query = "Select * From Wears where IsHome=1";
            return await _db.QueryAsync<ResultWearDto>(query);
        }

        public async Task<ResultWearDto> GetWearDetailAsync(int id)
        {
            var query = @"
                        SELECT 
                            w.*,
                            c.Name AS CategoryName
                        FROM Wears w
                        INNER JOIN Categories c 
                            ON c.CategoryId = w.CategoryId where WearId=@WearId";
            var parameters = new DynamicParameters();
            parameters.Add("WearId", id);
            return await _db.QueryFirstOrDefaultAsync<ResultWearDto>(query, parameters);
        }

        public async Task UpdateAsync(UpdateWearDto updateDto)
        {
            var query = "Update Wears Name=@Name,ImageUrl=@ImageUrl,Description=@Description,Price=@Price,CategoryId=@CategoryId,WearId=@WearId,IsHome=@IsHome values where WearId=@WearId";
            var parameters = new DynamicParameters(updateDto);
            await _db.ExecuteAsync(query, parameters);
        }
    }
}
