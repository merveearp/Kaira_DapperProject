using Kaira.WebUI.Repositories.CategoryRepositories;
using Microsoft.AspNetCore.Mvc;

namespace Kaira.WebUI.ViewComponents.WebUIHome
{
    public class _UICategoriesComponent(ICategoryRepository _categoryRepository) :ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = await _categoryRepository.GetAllAsync();
            return View(value);
        }
    }
}
