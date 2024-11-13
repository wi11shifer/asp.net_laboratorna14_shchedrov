using asp.net_laboratorna14_shchedrov.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using OpenTelemetry.Trace;

namespace asp.net_laboratorna14_shchedrov.Controllers
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
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

[HttpGet("data")]
    public IActionResult GetData()
    {
        var activity = Activity.Current;
        if (activity != null)
        {
            activity.SetTag("customAttribute", "value");
            activity.SetTag("userId", "12345");
        }
        return Ok("Data response");
    }

}
}
