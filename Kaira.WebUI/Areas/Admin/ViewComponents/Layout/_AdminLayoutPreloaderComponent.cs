using Microsoft.AspNetCore.Mvc;

namespace Kaira.WebUI.Areas.Admin.ViewComponents.Layout
{
    public class _AdminLayoutPreloaderComponent :ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();  
        }
    }
}
