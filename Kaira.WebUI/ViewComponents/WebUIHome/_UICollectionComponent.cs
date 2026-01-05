using Kaira.WebUI.Repositories.CollectionRepositories;
using Microsoft.AspNetCore.Mvc;

namespace Kaira.WebUI.ViewComponents.WebUIHome
{
    public class _UICollectionComponent(ICollectionRepository _collectionRepository) :ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _collectionRepository.GetAllAsync();
            return View(values);
        }
    }
}
