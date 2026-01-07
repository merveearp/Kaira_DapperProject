using Kaira.WebUI.Repositories.ProductRepositories;
using Microsoft.AspNetCore.Mvc;

namespace Kaira.WebUI.ViewComponents.WebUIHome
{
    public class _UINewArrivalComponent(IProductRepository _productRepository) :ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = (await _productRepository.GetAllAsync())
                .OrderByDescending(x => x.ProductId)
                .Take(8)
                .ToList();
            return View(values);
        }
    }
}
