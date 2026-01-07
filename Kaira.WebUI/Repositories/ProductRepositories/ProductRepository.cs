using Dapper;
using Kaira.WebUI.Context;
using Kaira.WebUI.DTOs.ProductDtos;
using System.Data;

namespace Kaira.WebUI.Repositories.ProductRepositories
{
    public class ProductRepository(AppDbContext context) : IProductRepository
    {
        private readonly IDbConnection _db = context.CreateConnection();
        public async Task CreateAsync(CreateProductDto createDto)
        {
            var query = "Insert into Products(Name,CoverImage,Image1,Image2,Description,Price,CategoryId,WearId,IsActive) values (@Name,@CoverImage,@Image1,@Image2,@Description,@Price,@Categoryıd,@WearId,@IsActive";
            var parameters = new DynamicParameters(createDto);
            await _db.ExecuteAsync(query, parameters);
        }

        public async Task DeleteAsync(int id)
        {
            string query = "Delete From Products where ProductId = @ProductId";
            var parameters = new DynamicParameters();
            parameters.Add("ProductId", id);
            await _db.ExecuteAsync(query, parameters);
        }

        public async Task<IEnumerable<ResultProductDto>> GetAllAsync()
        {
            var query = @"Select
                         p.* ,
                         w.Title AS WearTitle,
                         w.Subtitle AS WearSubtitle,
                         c.Name AS CategoryName
                         From Products p inner join Wears w on p.WearId=w.WearId 
                         inner join Categories c on c.CategoryId=p.CategoryId ";
            return await _db.QueryAsync<ResultProductDto>(query);
        }

        public async Task<IEnumerable<ResultProductDto>> GetByCategoryIdAsync(int id)
        {
            var query = "Select * From Products where CategoryId=@CategoryId";
            var parameters = new DynamicParameters();
            parameters.Add("CategoryId", id);
            return await _db.QueryAsync<ResultProductDto>(query,parameters);
        }

        public async Task<UpdateProductDto> GetByIdAsync(int id)
        {
            var query = "Select * From Products where ProductId=@ProductId";
            var parameters = new DynamicParameters();
            parameters.Add("ProductId", id);
            return await _db.QueryFirstOrDefaultAsync<UpdateProductDto>(query, parameters);
        }

        public async Task<IEnumerable<ResultProductDto>> GetByWearIdAsync(int id)
        {
            var query = @"Select
                         p.* ,
                         w.Title AS WearTitle,
                         w.Subtitle AS WearSubtitle,
                         c.Name AS CategoryName
                         From Products p inner join Wears w on p.WearId=w.WearId 
                         inner join Categories c on c.CategoryId=p.CategoryId
                            where p.WearId=@WearId";
            var parameters = new DynamicParameters();
            parameters.Add("WearId", id);
            return await _db.QueryAsync<ResultProductDto>(query, parameters);
        }

        public async Task<ResultProductDto> GetProductDetailAsync(int id)
        {
            var query = @"Select
                         p.* ,
                         w.Title AS WearTitle,
                         w.Subtitle AS WearSubtitle,
                         c.Name AS CategoryName
                         From Products p inner join Wears w on p.WearId=w.WearId 
                         inner join Categories c on c.CategoryId=p.CategoryId where ProductId=@ProductId";
            var parameters = new DynamicParameters();
            parameters.Add("ProductId", id);
            return await _db.QueryFirstOrDefaultAsync<ResultProductDto>(query, parameters);
        }

        public async Task<IEnumerable<ResultProductDto>> GetIsActiveAsync()
        {
            var query = @"Select
                         p.* ,
                         w.Title AS WearTitle,
                         w.Subtitle AS WearSubtitle,
                         c.Name AS CategoryName
                         From Products p inner join Wears w on p.WearId=w.WearId 
                         inner join Categories c on c.CategoryId=p.CategoryId where IsActive=1";
            return await _db.QueryAsync<ResultProductDto>(query);
        }

        public async Task UpdateAsync(UpdateProductDto updateDto)
        {
            var query = "Update Products set Name=@Name,Image1=@Image1,CoverImage=@CoverImage,Image2=@Image2,Description=@Description,Price=@Price,CategoryId=@CategoryId,WearId=@WearId,IsActive=@IsActive where ProductId=@ProductId";
            var parameters = new DynamicParameters(updateDto);
            await _db.ExecuteAsync(query, parameters);
        }
    }
}
