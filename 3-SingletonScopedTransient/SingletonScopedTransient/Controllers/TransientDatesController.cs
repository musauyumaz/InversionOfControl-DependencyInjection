using Microsoft.AspNetCore.Mvc;
using TestApi.Services;

namespace SingletonScopedTransient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransientDatesController(ITransientDateService _transientDateService1, ITransientDateService _transientDateService2) : ControllerBase
    {
        [HttpGet("Transient")]
        public IActionResult GetTransient()//20
        {
            string? time = _transientDateService1.GetDateTime.TimeOfDay.ToString();
            Task.Delay(1000).Wait();
            string? time2 = _transientDateService2.GetDateTime.TimeOfDay.ToString();
            List<string> times = new() { time, time2 };
            return Ok(times);
        }
    }
}
