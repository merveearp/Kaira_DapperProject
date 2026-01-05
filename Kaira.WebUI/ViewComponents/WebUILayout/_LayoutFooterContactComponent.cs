using Kaira.WebUI.Repositories.ContactRepositories;
using Microsoft.AspNetCore.Mvc;

namespace Kaira.WebUI.ViewComponents.WebUILayout
{
    public class _LayoutFooterContactComponent(IContactRepository _contactRepository) :ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = await _contactRepository.GetAsync();
            return View(value);
        }
    }
}
