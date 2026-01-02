using Microsoft.AspNetCore.Mvc;

namespace Kaira.WebUI.ViewComponents.WebUIHome
{
    public class _UIBestSellersComponent :ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
