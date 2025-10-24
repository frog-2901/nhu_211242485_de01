using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Nhu_211242485_de01.Models;

namespace Nhu_211242485_de01.Controllers
{
    public class NhuHomeController : Controller
    {
        private readonly ILogger<NhuHomeController> _logger;

        public NhuHomeController(ILogger<NhuHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult NhuIndex()
        {
            return View();
        }

        public IActionResult NhuPrivacy()
        {
            return View();
        }
        public IActionResult NhuContact()
        {
            return View();
        }
       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
