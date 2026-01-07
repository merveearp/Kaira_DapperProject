using Kaira.WebUI.Repositories.VideoRepositories;
using Microsoft.AspNetCore.Mvc;

namespace Kaira.WebUI.ViewComponents.WebUIHome
{
    public class _UIVideoComponent(IVideoRepository _videoRepository) :ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = await _videoRepository.GetAsync();
            return View(value);
        }
    }
}
