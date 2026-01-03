using Kaira.WebUI.DTOs.BannerDtos;

namespace Kaira.WebUI.Repositories.BannerRepositories
{
    public interface IBannerRepository
    {
        Task<UpdateBannerDto> GetAsync();
        Task UpdateAsync(UpdateBannerDto updateDto);
    }
}
