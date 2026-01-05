using Kaira.WebUI.DTOs.LogoDtos;
using Kaira.WebUI.Repositories.LogoRepositories;
using Microsoft.AspNetCore.Mvc;

namespace Kaira.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LogoController(ILogoRepository _logoRepository) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var values = await _logoRepository.GetAllAsync();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateLogo()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateLogo(CreateLogoDto createDto)
        {
            await _logoRepository.CreateAsync(createDto);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateLogo(int id)
        {
            var value = await _logoRepository.GetByIdAsync(id);
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateLogo(UpdateLogoDto updateDto)
        {
            await _logoRepository.UpdateAsync(updateDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteLogo(int id)
        {
            await _logoRepository.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
