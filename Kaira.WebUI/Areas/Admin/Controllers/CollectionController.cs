using Kaira.WebUI.DTOs.CollectionDtos;
using Kaira.WebUI.Repositories.CollectionRepositories;
using Microsoft.AspNetCore.Mvc;

namespace Kaira.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CollectionController(ICollectionRepository _collectionRepository) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var values = await _collectionRepository.GetAllAsync();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateCollection()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCollection(CreateCollectionDto createDto)
        {
            await _collectionRepository.CreateAsync(createDto);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateCollection(int id)
        {
            var value = await _collectionRepository.GetByIdAsync(id);
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateCollection(UpdateCollectionDto updateDto)
        {
            await _collectionRepository.UpdateAsync(updateDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteCollection(int id)
        {
            _collectionRepository.DeleteAsync(id);
            return RedirectToAction("Index");
        }

    }
}
