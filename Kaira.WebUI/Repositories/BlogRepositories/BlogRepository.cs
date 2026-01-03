using Dapper;
using Kaira.WebUI.Context;
using Kaira.WebUI.DTOs.BlogDtos;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Data;

namespace Kaira.WebUI.Repositories.BlogRepositories
{
    public class BlogRepository(AppDbContext context) : IBlogRepository
    {
        private readonly IDbConnection _db = context.CreateConnection();
        public async Task CreateAsync(CreateBlogDto createDto)
        {
            var query = "Insert into Blogs (Title,CoverImage,Description,CreatedDate,Subtitle) values (@Title,@CoverImage,@Description,@CreatedDate,@Subtitle)";
            createDto.CreatedDate = DateTime.Now;
            var parameters = new DynamicParameters(createDto);
            await _db.ExecuteAsync(query, parameters);
        }

        public async Task DeleteAsync(int id)
        {
            var query = "Delete From Blogs where BlogId=@BlogId";
            var parameters = new DynamicParameters();
            parameters.Add("BlogId", id);
            await _db.ExecuteAsync(query, parameters);
        }

        public async Task<IEnumerable<ResultBlogDto>> GetAllAsync()
        {
            var query = "Select * from Blogs";
            return await _db.QueryAsync<ResultBlogDto>(query);
        }

        public async Task<UpdateBlogDto> GetByIdAsync(int id)
        {
            var query = "Select * from Blogs where BlogId=@BlogId";
            var parameters = new DynamicParameters();
            parameters.Add("BlogId", id);
            return await _db.QueryFirstOrDefaultAsync<UpdateBlogDto>(query, parameters);
        }

        public async Task UpdateAsync(UpdateBlogDto updateDto)
        {
            var query = "Update Blogs set Title=@Title,CoverImage=@CoverImage,Description=@Description,Subtitle=@Subtitle ,UpdatedDate=@UpdatedDate where BlogId=@BlogId";
            updateDto.UpdatedDate = DateTime.Now;
            var parameters = new DynamicParameters(updateDto);
            await _db.ExecuteAsync(query, parameters);
        }
    }
}
