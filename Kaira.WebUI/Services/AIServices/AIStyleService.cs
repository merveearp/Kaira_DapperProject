using Kaira.WebUI.DTOs.AIDtos;
using Kaira.WebUI.Models;
using Kaira.WebUI.Services.OpenAIServices;
using Microsoft.Extensions.Options;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace Kaira.WebUI.Services.AIServices
{
    public class AIStyleService : IAIStyleService
    {
        private readonly IOpenAIService _openAIService;

        public AIStyleService(IOpenAIService openAIService)
        {
            _openAIService = openAIService;
        }

        public async Task<AIStyleResponseDto> GetStyleAsync(string userMessage)
        {
            var prompt = $@"
             Kullanıcının isteğine göre stil danışmanlığı yap.
             Sen Kaira markası için çalışan bir moda stil danışmanısın.
             Kullanıcıya kısa, net ve anlaşılır stil önerileri ver.
            - Kombin fikri ver
            - Gerçek ürün adı kullanma
               
            - Genel ve temsili konuş
             Cevabın sonunda kullanıcıyı 'Benzer parçalar için Kaira koleksiyonumuzu inceleyebilirsiniz.' şeklinde incelemeye yönlendir.
                

        Mesaj: {userMessage}
        ";

            var response = await _openAIService.SendAsync(prompt);

            return new AIStyleResponseDto
            {
                Title = "AI Stil Önerisi",
                Description = response
            };
        }

       
    }
    }





