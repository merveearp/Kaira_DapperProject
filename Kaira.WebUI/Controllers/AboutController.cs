using Kaira.WebUI.Repositories.AboutRepositories;
using Kaira.WebUI.Repositories.CoverImageRepositories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Kaira.WebUI.Controllers
{
    public class AboutController : Controller
    {
        private readonly IAboutRepository _aboutRepository;
        private readonly ICoverImageRepository _coverImageRepository;

        public AboutController(IAboutRepository aboutRepository, ICoverImageRepository coverImageRepository)
        {
            _aboutRepository = aboutRepository;
            _coverImageRepository = coverImageRepository;
        }

        public async Task<IActionResult> Index()
        {
            var value = await _aboutRepository.GetAsync();
            return View(value);
        }
    }
}
