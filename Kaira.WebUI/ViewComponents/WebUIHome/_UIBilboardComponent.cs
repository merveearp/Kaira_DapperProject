using Microsoft.AspNetCore.Mvc;

namespace Kaira.WebUI.ViewComponents.WebUIHome
{
    public class _UIBilboardComponent :ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
