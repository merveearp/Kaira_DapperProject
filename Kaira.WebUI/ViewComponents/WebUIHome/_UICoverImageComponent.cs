using Kaira.WebUI.Repositories.CoverImageRepositories;
using Microsoft.AspNetCore.Mvc;

namespace Kaira.WebUI.ViewComponents.WebUIHome
{
    public class _UICoverImageComponent(ICoverImageRepository _coverImageRepository) :ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _coverImageRepository.GetAllAsync();
            return View(values);
        }
    }
}
