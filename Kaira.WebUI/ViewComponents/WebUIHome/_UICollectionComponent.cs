using Microsoft.AspNetCore.Mvc;

namespace Kaira.WebUI.ViewComponents.WebUIHome
{
    public class _UICollectionComponent :ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
