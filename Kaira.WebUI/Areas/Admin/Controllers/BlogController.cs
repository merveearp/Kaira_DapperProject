using Kaira.WebUI.DTOs.BlogDtos;
using Kaira.WebUI.Repositories.BlogRepositories;
using Microsoft.AspNetCore.Mvc;

namespace Kaira.WebUI.Areas.Admin.Controllers
{
    public class BlogController(IBlogRepository _blogRepository) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var values = await _blogRepository.GetAllAsync();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateBlog()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateBlog(CreateBlogDto createDto)
        {
            await _blogRepository.CreateAsync(createDto);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateBlog(int id)
        {
            var value = await _blogRepository.GetByIdAsync(id);
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateBlog(UpdateBlogDto updateDto)
        {
            await _blogRepository.UpdateAsync(updateDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteBlog(int id)
        {
            _blogRepository.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
