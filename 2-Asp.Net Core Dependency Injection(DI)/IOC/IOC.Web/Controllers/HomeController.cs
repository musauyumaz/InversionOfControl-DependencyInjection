using IOC.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IOC.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IScopedDateService _scopedDateService;

        public HomeController(IScopedDateService scopedDateService)
        {
            _scopedDateService = scopedDateService;
        }

        public IActionResult Index([FromServices]IScopedDateService scopedDateService2)
        {
            ViewBag.time1 = _scopedDateService.GetDateTime.TimeOfDay.ToString();
            ViewBag.time2 = scopedDateService2.GetDateTime.TimeOfDay.ToString();
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