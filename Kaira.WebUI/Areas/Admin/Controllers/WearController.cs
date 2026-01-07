using Kaira.WebUI.DTOs.WearDtos;
using Kaira.WebUI.Repositories.CategoryRepositories;
using Kaira.WebUI.Repositories.WearRepositories;
using Kaira.WebUI.Repositories.WearRepositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Kaira.WebUI.Areas.Admin.Controllers
{
  
        [Area("Admin")]
        public class WearController(ICategoryRepository _categoryRepository, IWearRepository _wearRepository) : Controller
        {
            public async Task GetCategoryList()
            {
                var values = await _categoryRepository.GetAllAsync();
                ViewBag.CategoryList = values.Select(x => new SelectListItem
                {
                    Text = x.Name,
                    Value = x.CategoryId.ToString()
                }).ToList();
            }

            public async Task<IActionResult> Index()
            {
                var values = await _wearRepository.GetAllAsync();
                return View(values);
            }

            [HttpGet]
            public async Task<IActionResult> CreateWear()
            {
                await GetCategoryList();
                return View();
            }

            [HttpPost]
            public async Task<IActionResult> CreateWear(CreateWearDto createDto)
            {
                if (!ModelState.IsValid)
                {
                    await GetCategoryList();
                    return View(createDto);
                }

                await _wearRepository.CreateAsync(createDto);
                return RedirectToAction("Index");
            }

            [HttpGet]
            public async Task<IActionResult> UpdateWear(int id)
            {
                await GetCategoryList();
                var value = await _wearRepository.GetByIdAsync(id);
                return View(value);
            }

            [HttpPost]
            public async Task<IActionResult> UpdateWear(UpdateWearDto updateDto)
            {
                if (!ModelState.IsValid)
                {
                    await GetCategoryList();
                    return View(updateDto);
                }

                await _wearRepository.UpdateAsync(updateDto);
                return RedirectToAction("Index");
            }

            public async Task<IActionResult> DeleteWear(int id)
            {
                await _wearRepository.DeleteAsync(id);
                return RedirectToAction("Index");

            }

        }
    }

