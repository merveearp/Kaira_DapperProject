using Microsoft.AspNetCore.Mvc;

namespace Kaira.WebUI.ViewComponents.WebUILayout
{
    public class _LayoutHeadComponent :ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
