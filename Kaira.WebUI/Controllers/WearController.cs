using Kaira.WebUI.Repositories.WearRepositories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Kaira.WebUI.Controllers
{
    public class WearController(IWearRepository _wearRepository) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var values = await _wearRepository.GetAllAsync();
            return View(values);
        }
        public async Task<IActionResult> GetAllCategoryIndex()
        {
            var values = await _wearRepository.GetCategoryByAllAsync();
            return View(values);
        }
        public async Task<IActionResult> GetCategoryIdWear(int id)
        {
            var values = await _wearRepository.GetByCategoryIdAsync(id);
            return View(values);
        }
    }
}
