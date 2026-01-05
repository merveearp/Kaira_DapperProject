using Kaira.WebUI.DTOs.BannerDtos;
using Kaira.WebUI.Repositories.BannerRepositories;
using Microsoft.AspNetCore.Mvc;

namespace Kaira.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BannerController(IBannerRepository _bannerRepository) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var value = await _bannerRepository.GetAsync();
            return View(value);
        }

        [HttpGet]
        public async Task<IActionResult> UpdateBanner()
        {
            var value = await _bannerRepository.GetAsync();
            return View(value);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateBanner(UpdateBannerDto updateDto)
        {
            await _bannerRepository.UpdateAsync(updateDto);
            return RedirectToAction("Index");
        }
    }
}
