using Kaira.WebUI.DTOs.ServiceDtos;
using Kaira.WebUI.Repositories.ServiceRepositories;
using Microsoft.AspNetCore.Mvc;

namespace Kaira.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServiceController(IServiceRepository _serviceRepository) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var values = await _serviceRepository.GetAllAsync();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateService()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateService(CreateServiceDto createDto)
        {
            await _serviceRepository.CreateAsync(createDto);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateService(int id)
        {
            var value = await _serviceRepository.GetByIdAsync(id);
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateService(UpdateServiceDto updateDto)
        {
            await _serviceRepository.UpdateAsync(updateDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteService(int id)
        {
            await _serviceRepository.DeleteAsync(id);
            return RedirectToAction("Index");
        }

    }
}
