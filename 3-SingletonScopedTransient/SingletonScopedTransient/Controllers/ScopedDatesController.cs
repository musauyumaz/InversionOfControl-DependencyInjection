using Microsoft.AspNetCore.Mvc;
using TestApi.Services;

namespace SingletonScopedTransient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScopedDatesController(IScopedDateService _scopedDateService1, IScopedDateService _scopedDateService2) : ControllerBase
    {
        [HttpGet("Scoped")]
        public IActionResult GetScoped()
        {
            string? time = _scopedDateService1.GetDateTime.TimeOfDay.ToString();
            Task.Delay(1000).Wait();
            string? time2 = _scopedDateService2.GetDateTime.TimeOfDay.ToString();
            List<string> times = new() { time, time2 };
            return Ok(times);
        }
    }
}
