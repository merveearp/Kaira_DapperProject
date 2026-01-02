using Microsoft.AspNetCore.Mvc;

namespace Kaira.WebUI.ViewComponents.WebUILayout
{
    public class _LayoutFooterComponent :ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
