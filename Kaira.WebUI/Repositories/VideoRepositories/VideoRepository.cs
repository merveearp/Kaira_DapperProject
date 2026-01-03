using Dapper;
using Kaira.WebUI.Context;
using Kaira.WebUI.DTOs.VideoDtos;
using Kaira.WebUI.DTOs.VideoDtos;
using System.Data;

namespace Kaira.WebUI.Repositories.VideoRepositories
{
    public class VideoRepository(AppDbContext context) : IVideoRepository
    {
        private readonly IDbConnection _db = context.CreateConnection();
        public async Task<UpdateVideoDto> GetAsync()
        {
            var query = "Select * From Videos";
            return await _db.QueryFirstOrDefaultAsync<UpdateVideoDto>(query);
        }

        public async Task UpdateAsync(UpdateVideoDto updateDto)
        {
            var query = "Update Videos set Url=@Url, BackGroundImageUrl=@BackGroundImageUrl where VideoId=@VideoId";
            var parameters = new DynamicParameters(updateDto);
            await _db.ExecuteAsync(query, parameters);
        }
    }
}
