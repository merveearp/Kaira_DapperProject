using Kaira.WebUI.Repositories.CategoryRepositories;
using Kaira.WebUI.Repositories.ProductRepositories;
using Kaira.WebUI.Repositories.WearRepositories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Kaira.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController(ICategoryRepository _categoryRepository,IProductRepository _productRepository,IWearRepository _wearRepository ) : Controller
    {
        public async Task<IActionResult> Index()
        {
            ViewBag.CountCategory = (await _categoryRepository.GetAllAsync()).Count();
            ViewBag.CountProduct = (await _productRepository.GetAllAsync()).Count();
            ViewBag.CountWear = (await _wearRepository.GetAllAsync()).Count();

            return View();
        }
    }
}
