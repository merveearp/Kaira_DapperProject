using Kaira.WebUI.DTOs.AboutDtos;
using Kaira.WebUI.Repositories.AboutRepositories;
using Microsoft.AspNetCore.Mvc;

namespace Kaira.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutController(IAboutRepository _aboutRepository) : Controller
    {

        public async Task<IActionResult> Index()
        {
            var value = await _aboutRepository.GetAsync();
            return View(value);
        }

        [HttpGet]
        public async Task<IActionResult> UpdateAbout()
        {
            var value = await _aboutRepository.GetAsync();
            return View(value);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateAbout(UpdateAboutDto updateAboutDto)
        {
            await _aboutRepository.UpdateAsync(updateAboutDto);
            return RedirectToAction("Index");
        }
    }
}
