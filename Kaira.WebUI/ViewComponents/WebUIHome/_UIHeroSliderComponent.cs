using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace Kaira.WebUI.ViewComponents.WebUIHome
{
    public class _UIHeroSliderComponent :ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
