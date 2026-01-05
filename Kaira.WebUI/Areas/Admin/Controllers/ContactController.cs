using Kaira.WebUI.DTOs.ContactDtos;
using Kaira.WebUI.Repositories.ContactRepositories;
using Microsoft.AspNetCore.Mvc;

namespace Kaira.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactController (IContactRepository _contactRepository): Controller
    {
        public async Task<IActionResult> Index()
        {
            var value = await _contactRepository.GetAsync();
            return View(value);
        }

        [HttpGet]
        public async Task<IActionResult> UpdateContact()
        {
            var value = await _contactRepository.GetAsync();
            return View(value);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateContact(UpdateContactDto updateDto)
        {
            await _contactRepository.UpdateAsync(updateDto);
            return RedirectToAction("Index");
        }
    }
}
