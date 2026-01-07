using Kaira.WebUI.Repositories.ProductRepositories;
using Microsoft.AspNetCore.Mvc;

namespace Kaira.WebUI.ViewComponents.WebUIHome
{
    public class _UIBestSellersComponent(IProductRepository _productRepository) :ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = (await _productRepository.GetAllAsync())
                .Where(x => x.IsActive)
                .OrderBy(x => x.CategoryId)  
                .Take(10)
                .ToList();

            return View(values);
        }
    }
}
