using Kaira.WebUI.Repositories.BlogRepositories;
using Microsoft.AspNetCore.Mvc;

namespace Kaira.WebUI.Areas.Admin.ViewComponents.Home
{
    public class _AdminRecentBlogComponent(IBlogRepository blogRepository) :ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = (await blogRepository.GetAllAsync())
                .OrderByDescending(x=>x.BlogId)
                .Take(4)
                .ToList();
            return View(values);
        }
    }
}
