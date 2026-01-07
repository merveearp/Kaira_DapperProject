using Kaira.WebUI.DTOs.AIDtos;

namespace Kaira.WebUI.Services.AIServices
{
    public interface IAIStyleService
    {
        Task<AIStyleResponseDto> GetStyleAsync(string userMessage);
    }

}
