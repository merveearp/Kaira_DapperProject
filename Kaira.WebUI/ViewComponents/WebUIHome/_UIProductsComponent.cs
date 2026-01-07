using Kaira.WebUI.Repositories.ProductRepositories;
using Microsoft.AspNetCore.Mvc;

namespace Kaira.WebUI.ViewComponents.WebUIHome
{
    public class _UIProductsComponent(IProductRepository _productRepository) :ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = (await _productRepository.GetIsActiveAsync())
                .OrderBy(x=>x.WearId)
                .Take(10)
                .ToList();
            return View(values);
        }
    }
}
