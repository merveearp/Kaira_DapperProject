
using Kaira.WebUI.DTOs.ServiceDtos;

namespace Kaira.WebUI.Repositories.ServiceRepositories
{
    public interface IServiceRepository
    {
        Task<IEnumerable<ResultServiceDto>> GetAllAsync();
        Task<UpdateServiceDto> GetByIdAsync(int id);
        Task CreateAsync(CreateServiceDto createDto);
        Task UpdateAsync(UpdateServiceDto updateDto);
        Task DeleteAsync(int id);
    }
}
