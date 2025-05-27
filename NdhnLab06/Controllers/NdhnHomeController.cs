using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NdhnLab06.Models;

namespace NdhnLab06.Controllers
{
    public class NdhnHomeController : Controller
    {
        private readonly ILogger<NdhnHomeController> _logger;

        public NdhnHomeController(ILogger<NdhnHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult NdhnIndex()
        {
            return View();
        }

        public IActionResult NdhnAbout()
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
