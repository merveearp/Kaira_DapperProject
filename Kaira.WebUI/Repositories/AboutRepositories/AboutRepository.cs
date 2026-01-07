using Dapper;
using Kaira.WebUI.Context;
using Kaira.WebUI.DTOs.AboutDtos;
using Kaira.WebUI.DTOs.AboutDtos;
using System.Data;

namespace Kaira.WebUI.Repositories.AboutRepositories
{
    public class AboutRepository(AppDbContext context) : IAboutRepository
    {
        private readonly IDbConnection _db = context.CreateConnection();
        public async Task<UpdateAboutDto> GetAsync()
        {
            var query = "Select * From Abouts";
            return await _db.QueryFirstOrDefaultAsync<UpdateAboutDto>(query);
        }

        public async Task UpdateAsync(UpdateAboutDto updateDto)
        {
            var query = "Update Abouts set Title=@Title, Description=@Description ImageUrl=@ImageUrl , Text=@Text where AboutId=@AboutId";
            var parameters = new DynamicParameters(updateDto);
            await _db.ExecuteAsync(query, parameters);
        }
    }
}
