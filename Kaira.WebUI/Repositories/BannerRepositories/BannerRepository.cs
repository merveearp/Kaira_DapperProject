using Dapper;
using Kaira.WebUI.Context;
using Kaira.WebUI.DTOs.BannerDtos;
using System.Data;

namespace Kaira.WebUI.Repositories.BannerRepositories
{
    public class BannerRepository(AppDbContext context) : IBannerRepository
    {
        private readonly IDbConnection _db = context.CreateConnection();
        public async Task<UpdateBannerDto> GetAsync()
        {
            var query = "Select * From Banners";
            return await _db.QueryFirstOrDefaultAsync<UpdateBannerDto>(query);
        }

        public async Task UpdateAsync(UpdateBannerDto updateDto)
        {
            var query = "Update Banners set Title=@Title, Description=@Description where BannerId=@BannerId";
            var parameters = new DynamicParameters(updateDto);
            await _db.ExecuteAsync(query, parameters);
        }

    }
}
