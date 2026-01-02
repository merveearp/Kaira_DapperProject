using Microsoft.AspNetCore.Mvc;

namespace Kaira.WebUI.ViewComponents.WebUIHome
{
    public class _UIProductsComponent :ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
