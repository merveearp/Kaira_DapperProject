using Kaira.WebUI.Repositories.LogoRepositories;
using Microsoft.AspNetCore.Mvc;

namespace Kaira.WebUI.ViewComponents.WebUIHome
{
    public class _UILogoComponent(ILogoRepository _logoRepository) :ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _logoRepository.GetAllAsync();   
            return View(values);
        }
    }
}
