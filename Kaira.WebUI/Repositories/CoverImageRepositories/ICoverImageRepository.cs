

using Kaira.WebUI.DTOs.CoverImageDtos;

namespace Kaira.WebUI.Repositories.CoverImageRepositories
{
    public interface ICoverImageRepository
    {
        Task<IEnumerable<ResultCoverImageDto>> GetAllAsync();
        Task<UpdateCoverImageDto> GetByIdAsync(int id);
        Task CreateAsync(CreateCoverImageDto createDto);
        Task UpdateAsync(UpdateCoverImageDto updateDto);
        Task DeleteAsync(int id);
    }
}
