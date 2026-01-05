using Kaira.WebUI.Repositories.BannerRepositories;
using Microsoft.AspNetCore.Mvc;

namespace Kaira.WebUI.ViewComponents.WebUIHome
{
    public class _UIBilboardComponent(IBannerRepository _bannerRepository) :ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = await _bannerRepository.GetAsync();
            return View(value);
        }
    }
}
