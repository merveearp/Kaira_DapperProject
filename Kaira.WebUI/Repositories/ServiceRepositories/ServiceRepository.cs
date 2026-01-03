using Kaira.WebUI.Context;
using Kaira.WebUI.DTOs.ServiceDtos;
using System.Data;
using Dapper;


namespace Kaira.WebUI.Repositories.ServiceRepositories
{
    public class ServiceRepository(AppDbContext context) : IServiceRepository
    {
        private readonly IDbConnection _db = context.CreateConnection();

        public async Task CreateAsync(CreateServiceDto createDto)
        {
            string query = "Insert into Service (Title,Description,Icon) values (@Title,@Description,@Icon)";
            var parameters = new DynamicParameters(createDto);
            await _db.ExecuteAsync(query, parameters);
        }

        public async Task DeleteAsync(int id)
        {
            var query = "Delete From Services where ServiceId =@ServiceId";
            var parameters = new DynamicParameters();
            parameters.Add("ServiceId", id);
            await _db.ExecuteAsync(query, parameters);

        }

        public async Task<IEnumerable<ResultServiceDto>> GetAllAsync()
        {
            var query = "Select * From Services";
            return await _db.QueryAsync<ResultServiceDto>(query);
        }

        public async Task<UpdateServiceDto> GetByIdAsync(int id)
        {
            var query = "Select * From Services where ServiceId= @ServiceId";
            var parameters = new DynamicParameters();
            parameters.Add("ServiceId", id);
            return await _db.QueryFirstOrDefaultAsync<UpdateServiceDto>(query, parameters);

        }

        public async Task UpdateAsync(UpdateServiceDto updateDto)
        {
            string query = "Update Services set Title=@Title, Description=@Description, Icon=@Icon where ServiceId = @ServiceId";
            var parameters = new DynamicParameters(updateDto);
            await _db.ExecuteAsync(query, parameters);
        }
    }
}
