using Kaira.WebUI.DTOs.AboutDtos;

namespace Kaira.WebUI.Repositories.AboutRepositories
{
    public interface IAboutRepository
    {
        Task<UpdateAboutDto> GetAsync();
        Task UpdateAsync(UpdateAboutDto updateDto);
    }
}

