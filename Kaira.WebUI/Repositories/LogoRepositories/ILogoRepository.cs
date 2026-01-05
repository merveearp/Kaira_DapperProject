using Kaira.WebUI.DTOs.LogoDtos;

namespace Kaira.WebUI.Repositories.LogoRepositories
{
    public interface ILogoRepository
    {
        Task<IEnumerable<ResultLogoDto>> GetAllAsync();
        Task<UpdateLogoDto> GetByIdAsync(int id);
        Task CreateAsync(CreateLogoDto createDto);
        Task UpdateAsync(UpdateLogoDto updateDto);
        Task DeleteAsync(int id);
    }
}
