using Dapper;
using Kaira.WebUI.Context;
using Kaira.WebUI.DTOs.FAQDtos;
using System.Data;

namespace Kaira.WebUI.Repositories.FAQRepositories
{
    public class FAQRepository(AppDbContext context) : IFAQRepository
    {
        private readonly IDbConnection _db = context.CreateConnection();
        public async Task CreateAsync(CreateFAQDto createDto)
        {
            var query = "Insert into FAQs (Question,Answer) values (@Question,@Answer)";
            var parameters = new DynamicParameters(createDto);
            await _db.ExecuteAsync(query, parameters);
        }

        public async Task DeleteAsync(int id)
        {
            var query = "Delete From FAQs where FAQId=@FAQId";
            var parameters = new DynamicParameters();
            parameters.Add("FAQId", id);
            await _db.ExecuteAsync(query, parameters);
        }

        public async Task<IEnumerable<ResultFAQDto>> GetAllAsync()
        {
            var query = "Select * from FAQs";
            return await _db.QueryAsync<ResultFAQDto>(query);
        }

        public async Task<UpdateFAQDto> GetByIdAsync(int id)
        {
            var query = "Select * from FAQ where FAQId=@FAQId";
            var parameters = new DynamicParameters();
            parameters.Add("FAQId", id);
            return await _db.QueryFirstOrDefaultAsync<UpdateFAQDto>(query, parameters);
        }

        public async Task UpdateAsync(UpdateFAQDto updateDto)
        {
            var query = "Update FAQs set Question=@Question,Answer=@Answer where FAQId=@FAQId";
            var parameters = new DynamicParameters(updateDto);
            await _db.ExecuteAsync(query, parameters);
        }
    }
}
