using Kaira.WebUI.DTOs.BlogDtos;

namespace Kaira.WebUI.Repositories.BlogRepositories
{
    public interface IBlogRepository
    {
        Task<IEnumerable<ResultBlogDto>> GetAllAsync();
        Task<UpdateBlogDto> GetByIdAsync(int id);
        Task CreateAsync(CreateBlogDto createDto);
        Task UpdateAsync(UpdateBlogDto updateDto);
        Task DeleteAsync(int id);
    }
}
