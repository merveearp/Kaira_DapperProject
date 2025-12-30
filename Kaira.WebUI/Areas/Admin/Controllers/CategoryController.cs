using Kaira.WebUI.Repositories.CategoryRepositories;
using Microsoft.AspNetCore.Mvc;

namespace Kaira.WebUI.Areas.Admin.Controllers
{
    public class CategoryController(ICategoryRepository _categoryRepository) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var values = await _categoryRepository.GetAllAsync();
            return View(values);
        }
    }
}
