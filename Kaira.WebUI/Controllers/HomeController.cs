using Kaira.WebUI.DTOs.AIDtos;
using Kaira.WebUI.Models;
using Kaira.WebUI.Services.AIServices;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Kaira.WebUI.Controllers
{
   
    public class HomeController : Controller
    {
        private readonly IAIStyleService _aiStyleService;

        public HomeController(IAIStyleService aiStyleService)
        {
            _aiStyleService = aiStyleService;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult AskStyle()
        {
            return View(new AIStyleResponseDto());
        }

        [HttpPost]
        public async Task<IActionResult> AskStyle(string userMessage)
        {
            if (string.IsNullOrWhiteSpace(userMessage))
            {
                ViewBag.OpenModal = true;
                return View("Index", new AIStyleResponseDto());
            }


            var result = await _aiStyleService.GetStyleAsync(userMessage);


            ViewBag.OpenModal = true;

            return View("Index", result);
        }


    }
}
