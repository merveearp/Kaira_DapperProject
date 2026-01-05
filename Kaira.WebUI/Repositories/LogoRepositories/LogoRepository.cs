using Dapper;
using Kaira.WebUI.Context;
using Kaira.WebUI.DTOs.LogoDtos;
using Kaira.WebUI.DTOs.LogoDtos;
using System.Data;

namespace Kaira.WebUI.Repositories.LogoRepositories
{
    public class LogoRepository(AppDbContext context) : ILogoRepository
    {
        private readonly IDbConnection _db = context.CreateConnection();
        public async Task CreateAsync(CreateLogoDto createDto)
        {
            var query = "insert into Logos (ImageUrl) values (@Logo)";
            var parameters = new DynamicParameters(createDto);
            await _db.ExecuteAsync(query, parameters);
        }

        public async Task DeleteAsync(int id)
        {
            var query = "Delete From Logos where LogoId=@LogoId ";
            var parameters = new DynamicParameters();
            parameters.Add("LogoId", id);
            await _db.ExecuteAsync(query, parameters);
        }

        public async Task<IEnumerable<ResultLogoDto>> GetAllAsync()
        {
            var query = "Select * From Logos";
            return await _db.QueryAsync<ResultLogoDto>(query);
        }

        public async Task<UpdateLogoDto> GetByIdAsync(int id)
        {
            var query = "Select * From Logos where LogoId=@LogoId ";
            var parameters = new DynamicParameters();
            parameters.Add("LogoId", id);
            return await _db.QueryFirstOrDefaultAsync<UpdateLogoDto>(query, parameters);
        }

        public async Task UpdateAsync(UpdateLogoDto updateDto)
        {
            var query = "Update Logos set ImageUrl=@ImageUrl where LogoId=@LogoId ";
            var parameters = new DynamicParameters(updateDto);
            await _db.ExecuteAsync(query, parameters);
        }
    }
}
