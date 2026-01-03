using Dapper;
using Kaira.WebUI.Context;
using Kaira.WebUI.DTOs.CoverImageDtos;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Data;

namespace Kaira.WebUI.Repositories.CoverImageRepositories
{
    public class CoverImageRepository(AppDbContext context) : ICoverImageRepository 
    {
        private readonly IDbConnection _db = context.CreateConnection();
        public async Task CreateAsync(CreateCoverImageDto createDto)
        {
            var query = "insert into CoverImages (CoverImage) values (@CoverImage)";
            var parameters = new DynamicParameters(createDto);
            await _db.ExecuteAsync(query, parameters);
        }

        public async Task DeleteAsync(int id)
        {
            var query = "Delete From CoverImages where CoverId=@CoverId ";
            var parameters = new DynamicParameters();
            parameters.Add("CoverId", id);
            await _db.ExecuteAsync(query, parameters);
        }

        public async Task<IEnumerable<ResultCoverImageDto>> GetAllAsync()
        {
            var query = "Select * From CoverImages";
            return await _db.QueryAsync<ResultCoverImageDto>(query);
        }

        public async Task<UpdateCoverImageDto> GetByIdAsync(int id)
        {
            var query = "Select * From CoverImages where CoverId=@CoverId ";
            var parameters = new DynamicParameters();
            parameters.Add("CoverId", id);
            return await _db.QueryFirstOrDefaultAsync<UpdateCoverImageDto>(query, parameters);
        }

        public async Task UpdateAsync(UpdateCoverImageDto updateDto)
        {
            var query = "Update CoverImages set CoverImage=@CoverImage where CoverId=@CoverId ";
            var parameters = new DynamicParameters(updateDto);
            await _db.ExecuteAsync(query, parameters);
        }
    }
}
