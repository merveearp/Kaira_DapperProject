using Microsoft.AspNetCore.Mvc;

namespace Kaira.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
