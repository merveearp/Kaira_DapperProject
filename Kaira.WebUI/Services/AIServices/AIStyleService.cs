using Kaira.WebUI.DTOs.AIDtos;
using Kaira.WebUI.Models;
using Microsoft.Extensions.Options;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace Kaira.WebUI.Services.AIServices
{
    public class AIStyleService : IAIStyleService
    {
        private readonly HttpClient _httpClient;
        private readonly OpenAISettings _openAISettings;

        public AIStyleService(
            HttpClient httpClient,
            IOptions<OpenAISettings> openAIOptions)
        {
            _httpClient = httpClient;
            _openAISettings = openAIOptions.Value;
        }


        public async Task<AIStyleResponseDto> GetStyleAsync(string userMessage)
        {
            var systemPrompt = @"
                Sen Kaira markası için çalışan bir moda stil danışmanısın.
                Kullanıcıya kısa, net ve anlaşılır stil önerileri ver.
                Cevabın sonunda kullanıcıyı ürünlerimizi incelemeye yönlendir.
                
                ";

            var requestBody = new
            {
                model = _openAISettings.Model,
                messages = new[]
                {
                    new
                    {
                        role = "system",
                        content = systemPrompt
                    },
                    new
                    {
                        role = "user",
                        content = userMessage
                    }
                }
            };

            var jsonBody = JsonSerializer.Serialize(requestBody);

            var request = new HttpRequestMessage(HttpMethod.Post, "https://api.openai.com/v1/chat/completions"
            );

            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _openAISettings.ApiKey);

            request.Content =
                new StringContent(jsonBody, Encoding.UTF8, "application/json");

            var response = await _httpClient.SendAsync(request);
            var responseString = await response.Content.ReadAsStringAsync();

            var json = JsonDocument.Parse(responseString);
            var aiMessage = json.RootElement
                .GetProperty("choices")[0]
                .GetProperty("message")
                .GetProperty("content")
                .GetString();

            return new AIStyleResponseDto
            {
                Title = "Stil Danışmanı",
                Description = aiMessage
            };
        }

    }
}
