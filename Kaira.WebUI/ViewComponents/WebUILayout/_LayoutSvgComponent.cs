using Microsoft.AspNetCore.Mvc;

namespace Kaira.WebUI.ViewComponents.WebUILayout
{
    public class _LayoutSvgComponent :ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
