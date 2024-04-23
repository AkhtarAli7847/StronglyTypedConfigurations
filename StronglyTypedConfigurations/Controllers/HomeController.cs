using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Options;
using StronglyTypedConfigurations.Common;
using StronglyTypedConfigurations.Models;
using StronglyTypedConfigurations.Services;
using System.Diagnostics;

namespace StronglyTypedConfigurations.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MyService _service;

        public HomeController(ILogger<HomeController> logger, MyService service)
        {
            _logger = logger;
            _service=service;
        }

        public IActionResult Index()
        {
            var configs = _service.GetApiConfig();

            return View();
        }

        public IActionResult Privacy()
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
