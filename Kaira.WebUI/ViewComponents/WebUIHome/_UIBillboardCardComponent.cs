using Kaira.WebUI.Repositories.WearRepositories;
using Microsoft.AspNetCore.Mvc;

namespace Kaira.WebUI.ViewComponents.WebUIHome
{
    public class _UIBillboardCardComponent(IWearRepository _wearRepository) :ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = (await _wearRepository.GetIsHomeAsync())
                .OrderByDescending(x => x.WearId)
                .Take(8)
                .ToList();
            return View(values);
        }
    }
}
