

using Kaira.WebUI.DTOs.FAQDtos;

namespace Kaira.WebUI.Repositories.FAQRepositories
{
    public interface IFAQRepository
    {
        Task<IEnumerable<ResultFAQDto>> GetAllAsync();
        Task<UpdateFAQDto> GetByIdAsync(int id);
        Task CreateAsync(CreateFAQDto createDto);
        Task UpdateAsync(UpdateFAQDto updateDto);
        Task DeleteAsync(int id);
    }
}
