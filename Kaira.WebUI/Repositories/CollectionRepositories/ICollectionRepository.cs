

using Kaira.WebUI.DTOs.CollectionDtos;

namespace Kaira.WebUI.Repositories.CollectionRepositories
{
    public interface ICollectionRepository
    {
        Task<IEnumerable<ResultCollectionDto>> GetAllAsync();
        Task<UpdateCollectionDto> GetByIdAsync(int id);
        Task CreateAsync(CreateCollectionDto createDto);
        Task UpdateAsync(UpdateCollectionDto updateDto);
        Task DeleteAsync(int id);
    }
}
