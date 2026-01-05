using Kaira.WebUI.Repositories.BlogRepositories;
using Microsoft.AspNetCore.Mvc;

namespace Kaira.WebUI.Controllers
{
    public class BlogController(IBlogRepository _blogRepository) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var values = await _blogRepository.GetAllAsync();
            return View(values);
        }

        public async Task<IActionResult> BlogDetail(int id)
        {
            var value = await _blogRepository.GetDetailAsync(id);
            return View(value);
        }
    }
}
