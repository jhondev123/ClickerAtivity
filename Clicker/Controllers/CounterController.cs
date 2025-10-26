using Microsoft.AspNetCore.Mvc;

namespace Clicker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CounterController : ControllerBase
    {
        [HttpGet("current")]
        public IActionResult GetCurrentCount()
        {
            return Ok(new { Count = 0 });
        }

        [HttpGet("increment")]
        public IActionResult Increment([FromQuery] int value)
        {
            var result = value + 1;
            return Ok(result);
        }
    }
}
