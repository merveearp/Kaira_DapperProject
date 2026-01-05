using Kaira.WebUI.DTOs.FAQDtos;
using Kaira.WebUI.Repositories.FAQRepositories;
using Microsoft.AspNetCore.Mvc;

namespace Kaira.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FAQController(IFAQRepository _fAQRepository): Controller
    {
        public async Task<IActionResult> Index()
        {
            var values = await _fAQRepository.GetAllAsync();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateFAQ()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateFAQ(CreateFAQDto createDto)
        {
            await _fAQRepository.CreateAsync(createDto);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateFAQ(int id)
        {
            var value = await _fAQRepository.GetByIdAsync(id);
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateFAQ(UpdateFAQDto updateDto)
        {
            await _fAQRepository.UpdateAsync(updateDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteFAQ(int id)
        {
            _fAQRepository.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
