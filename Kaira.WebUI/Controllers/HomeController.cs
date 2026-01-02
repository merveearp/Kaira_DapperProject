using System.Diagnostics;
using Kaira.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kaira.WebUI.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

       
    }
}
