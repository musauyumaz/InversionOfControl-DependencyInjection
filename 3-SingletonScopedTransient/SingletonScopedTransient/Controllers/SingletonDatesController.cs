using Microsoft.AspNetCore.Mvc;
using TestApi.Services;

namespace SingletonScopedTransient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SingletonDatesController(ISingletonDateService _singletonDateService1, ISingletonDateService _singletonDateService2) : ControllerBase
    {
        [HttpGet("Singleton")]
        public IActionResult GetSingleton()
        {
            string? time = _singletonDateService1.GetDateTime.TimeOfDay.ToString();
            Task.Delay(1000).Wait();
            string? time2 = _singletonDateService2.GetDateTime.TimeOfDay.ToString();
            List<string> times = new() { time, time2 };
            return Ok(times);
        }
    }
}
