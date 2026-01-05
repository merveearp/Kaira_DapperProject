using Kaira.WebUI.Repositories.ServiceRepositories;
using Microsoft.AspNetCore.Mvc;

namespace Kaira.WebUI.ViewComponents.WebUIHome
{
    public class _UIFeatureComponent(IServiceRepository _serviceRepository) :ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _serviceRepository.GetAllAsync();
            return View(values);
        }
    }
}
