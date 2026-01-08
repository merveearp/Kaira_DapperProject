namespace Kaira.WebUI.Services.OpenAIServices
{
    public interface IOpenAIService
    {
        Task<string> SendAsync(string prompt);
    
    }
}
