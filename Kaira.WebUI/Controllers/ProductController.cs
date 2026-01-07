using Kaira.WebUI.Repositories.ProductRepositories;
using Microsoft.AspNetCore.Mvc;

namespace Kaira.WebUI.Controllers
{
    public class ProductController(IProductRepository _productRepository) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var values = await _productRepository.GetAllAsync();
            return View(values);
        }

        public async Task<IActionResult> ProductDetail(int id)
        {
            var value = await _productRepository.GetProductDetailAsync(id);
            return View(value);
        }
        public async Task<IActionResult> GetWearByProduct(int id)
        {
            var value = await _productRepository.GetByWearIdAsync(id);
            return View(value);
        }

        public async Task<IActionResult> GetCategoryByProduct(int id)
        {
            var value = await _productRepository.GetByCategoryIdAsync(id);
            return View(value);
        }

    }
}
