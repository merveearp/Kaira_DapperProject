using Kaira.WebUI.Repositories.FAQRepositories;
using Microsoft.AspNetCore.Mvc;

namespace Kaira.WebUI.Controllers
{
    public class FAQController(IFAQRepository _fAQRepository) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var values = await _fAQRepository.GetAllAsync();   
            return View(values);
        }
    }
}
