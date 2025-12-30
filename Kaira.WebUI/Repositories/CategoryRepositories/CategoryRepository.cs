using Dapper;
using Kaira.WebUI.Context;
using Kaira.WebUI.DTOs.CategoryDtos;
using System.Data;

namespace Kaira.WebUI.Repositories.CategoryRepositories
{
    public class CategoryRepository(AppDbContext context) : ICategoryRepository
    {
        private readonly IDbConnection _db = context.CreateConnection();
        
        public async Task CreateAsync(CreateCategoryDto categoryDto)
        {
            string query = "Insert into Categories(Name) values (@Name)";
            var parameters = new DynamicParameters(categoryDto);
            await _db.ExecuteAsync(query, parameters);
        }

        public async Task DeleteAsync(int id)
        {
            string query = "Delete From Categories where CategoryId = @CategoryId";
            var parameters = new DynamicParameters();
            parameters.Add("CategoryId",id);
            await _db.ExecuteAsync(query, parameters);
        }

        public async Task<IEnumerable<ResultCategoryDto>> GetAllAsync()
        {
            string query = "Select * From Categories";
            return await _db.QueryAsync<ResultCategoryDto>(query);
        }

        public async Task<UpdateCategoryDto> GetByIdAsync(int id)
        {
            string query = "Select * From Categories where CategoryId =@CategoryId ";
            var parameters = new DynamicParameters();
            parameters.Add("@CategoryId", id);
            return await _db.QueryFirstOrDefaultAsync<UpdateCategoryDto>(query,parameters);
        }

        public async Task UpdateAsync(UpdateCategoryDto categoryDto)
        {
            string query = "Update Categories set Name = @Name where CategoryId =@CategoryId";
            var parameters = new DynamicParameters(categoryDto);
            await _db.ExecuteAsync(query, parameters);
        }
    }
}
