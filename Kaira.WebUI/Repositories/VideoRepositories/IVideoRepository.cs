using Kaira.WebUI.DTOs.VideoDtos;

namespace Kaira.WebUI.Repositories.VideoRepositories
{
    public interface IVideoRepository
    {
        Task<UpdateVideoDto> GetAsync();
        Task UpdateAsync(UpdateVideoDto updateDto);
    }
}
