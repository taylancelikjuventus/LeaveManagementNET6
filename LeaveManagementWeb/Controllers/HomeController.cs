using LeaveManagementWeb.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LeaveManagementWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            var requestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            var excptionHandlerPathFeature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();

            if (excptionHandlerPathFeature != null)
            {
                Exception exception = excptionHandlerPathFeature.Error;
                _logger.LogError(
                    exception,
                    $"Error occured by user: {this.User?.Identity?.Name} | request ID: {requestId}");
            }

            return View(new ErrorViewModel { RequestId = requestId });
        }
    }
}