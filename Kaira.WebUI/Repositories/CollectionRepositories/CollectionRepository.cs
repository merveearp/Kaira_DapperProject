using Dapper;
using Kaira.WebUI.Context;
using Kaira.WebUI.DTOs.CollectionDtos;
using System.Data;

namespace Kaira.WebUI.Repositories.CollectionRepositories
{
    public class CollectionRepository(AppDbContext context) : ICollectionRepository
    {
        private readonly IDbConnection _db = context.CreateConnection();
        public async Task CreateAsync(CreateCollectionDto createDto)
        {
            var query = "Insert into Collections (ImageUrl,Title,Description) values (@ImageUrl,@Title,@Description)";
            var parameters = new DynamicParameters(createDto);
            await _db.ExecuteAsync(query, parameters);
        }

        public async Task DeleteAsync(int id)
        {
            var query = "Delete From Collections where CollectionId=@CollectionId";
            var parameters = new DynamicParameters();
            parameters.Add("CollectionId", id);
            await _db.ExecuteAsync(query, parameters);
        }

        public async Task<IEnumerable<ResultCollectionDto>> GetAllAsync()
        {
            var query = "Select * from Collections";
            return await _db.QueryAsync<ResultCollectionDto>(query);
        }

        public async Task<UpdateCollectionDto> GetByIdAsync(int id)
        {
            var query = "Select * from Collections where CollectionId=@CollectionId";
            var parameters = new DynamicParameters();
            parameters.Add("CollectionId", id);
            return await _db.QueryFirstOrDefaultAsync<UpdateCollectionDto>(query, parameters);
        }

        public async Task UpdateAsync(UpdateCollectionDto updateDto)
        {
            var query = "Update Collections set Title=@Title,ImageUrl=@ImageUrl,Description=@Description where CollectionId=@CollectionId";
            var parameters = new DynamicParameters(updateDto);
            await _db.ExecuteAsync(query, parameters);
        }
    }
}
