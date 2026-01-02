using Microsoft.AspNetCore.Mvc;

namespace Kaira.WebUI.Areas.Admin.ViewComponents.Layout
{
    public class _AdminLayoutHeadComponent :ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
