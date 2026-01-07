using Kaira.WebUI.DTOs.ProductDtos;
using Kaira.WebUI.Repositories.CategoryRepositories;
using Kaira.WebUI.Repositories.ProductRepositories;
using Kaira.WebUI.Repositories.WearRepositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;

namespace Kaira.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController(IProductRepository _productRepository,ICategoryRepository _categoryRepository,IWearRepository _wearRepository) : Controller
    {
        public async Task GetCategoryList()
        {
            var values = await _categoryRepository.GetAllAsync();
            ViewBag.CategoryList = values.Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.CategoryId.ToString()
            }).ToList();
        }

        public async Task GetWearList()
        {
            var values = await _wearRepository.GetAllAsync();
            ViewBag.WearList = values.Select(x => new SelectListItem
            {
                Text = x.Subtitle,
                Value = x.WearId.ToString()
            }).ToList();
        }

        public async Task<IActionResult> Index()
        {
            var values = await _productRepository.GetAllAsync();
            return View(values);
        }
        
        [HttpGet]
        public async Task<IActionResult> CreateProduct()
        {
            await GetCategoryList();
            await GetWearList();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductDto createDto)
        {
            if (!ModelState.IsValid)
            {
                await GetCategoryList();
                await GetWearList();
                return View(createDto);
            }

            await _productRepository.CreateAsync(createDto);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateProduct(int id)
        {
            await GetCategoryList();
            await GetWearList();
            var value = await _productRepository.GetByIdAsync(id);
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProduct(UpdateProductDto updateDto)
        {
            if (!ModelState.IsValid)
            {
                await GetCategoryList();
                await GetWearList();
                return View(updateDto);
            }

            await _productRepository.UpdateAsync(updateDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteProduct(int id)
        {
            await _productRepository.DeleteAsync(id);
            return RedirectToAction("Index");

        }

    }
}
