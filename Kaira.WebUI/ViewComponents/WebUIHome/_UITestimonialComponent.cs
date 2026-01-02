using Microsoft.AspNetCore.Mvc;

namespace Kaira.WebUI.ViewComponents.WebUIHome
{
    public class _UITestimonialComponent :ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
