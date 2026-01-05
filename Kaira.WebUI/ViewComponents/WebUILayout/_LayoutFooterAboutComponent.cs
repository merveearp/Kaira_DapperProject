using Kaira.WebUI.Repositories.AboutRepositories;
using Microsoft.AspNetCore.Mvc;

namespace Kaira.WebUI.ViewComponents.WebUILayout
{
    public class _LayoutFooterAboutComponent(IAboutRepository _aboutRepository) :ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = await _aboutRepository.GetAsync();
            return View(value);
        }
    }
}
