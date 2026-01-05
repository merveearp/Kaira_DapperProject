using Kaira.WebUI.DTOs.CoverImageDtos;
using Kaira.WebUI.Repositories.CoverImageRepositories;
using Microsoft.AspNetCore.Mvc;

namespace Kaira.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CoverImageController (ICoverImageRepository _coverImageRepository): Controller
    {
        public async Task<IActionResult> Index()
        {
            var values = await _coverImageRepository.GetAllAsync();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateCoverImage()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCoverImage(CreateCoverImageDto createDto)
        {
            await _coverImageRepository.CreateAsync(createDto);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateCoverImage(int id)
        {
            var value = await _coverImageRepository.GetByIdAsync(id);
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateCoverImage(UpdateCoverImageDto updateDto)
        {
            await _coverImageRepository.UpdateAsync(updateDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteCoverImage(int id)
        {
            await _coverImageRepository.DeleteAsync(id);
            return RedirectToAction("Index");
        }

    }
}
