using Kaira.WebUI.Repositories.BlogRepositories;
using Microsoft.AspNetCore.Mvc;

namespace Kaira.WebUI.ViewComponents.WebUIHome
{
    public class _UIBlogComponent(IBlogRepository _blogRepository) :ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = (await _blogRepository.GetAllAsync())
                .OrderByDescending(x =>x.BlogId)
                .Take(3)
                .ToList();
            return View(values);  
        }
    }
}
