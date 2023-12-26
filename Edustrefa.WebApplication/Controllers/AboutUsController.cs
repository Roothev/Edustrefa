using Edustrefa.WebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Edustrefa.WebApplication.Controllers
{
    public class AboutUsController : Controller
    {
        private readonly ILogger<AboutUsController> _logger;

        public AboutUsController(ILogger<AboutUsController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }
    }
}
