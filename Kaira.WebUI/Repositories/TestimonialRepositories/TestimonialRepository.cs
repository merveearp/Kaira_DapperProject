using Dapper;
using Kaira.WebUI.Context;
using Kaira.WebUI.DTOs.TestimonialDtos;
using Kaira.WebUI.DTOs.TestimonialDtos;
using System.Data;

namespace Kaira.WebUI.Repositories.TestimonialRepositories
{
    public class TestimonialRepository(AppDbContext context) : ITestimonialRepository
    {
        private readonly IDbConnection _db = context.CreateConnection();
        public async Task CreateAsync(CreateTestimonialDto createDto)
        {
            var query = "Insert into Testimonials (NameSurname,Comment) values (@NameSurname,@Comment)";
            var parameters = new DynamicParameters(createDto);
            await _db.ExecuteAsync(query, parameters);
        }

        public async Task DeleteAsync(int id)
        {
            var query = "Delete From Testimonials where TestimonialId=@TestimonialId";
            var parameters = new DynamicParameters();
            parameters.Add("TestimonialId", id);
            await _db.ExecuteAsync(query, parameters);
        }

        public async Task<IEnumerable<ResultTestimonialDto>> GetAllAsync()
        {
            var query = "Select * from Testimonials";
            return await _db.QueryAsync<ResultTestimonialDto>(query);
        }

        public async Task<UpdateTestimonialDto> GetByIdAsync(int id)
        {
            var query = "Select * from Testimonials where TestimonialId=@TestimonialId";
            var parameters = new DynamicParameters();
            parameters.Add("TestimonialId", id);
            return await _db.QueryFirstOrDefaultAsync<UpdateTestimonialDto>(query, parameters);
        }

        public async Task UpdateAsync(UpdateTestimonialDto updateDto)
        {
            var query = "Update Testimonials set NameSurname=@NameSurname,Comment=@Comment where TestimonialId=@TestimonialId";
            var parameters = new DynamicParameters(updateDto);
            await _db.ExecuteAsync(query, parameters);
        }
    }
}
