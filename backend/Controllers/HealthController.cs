using Microsoft.AspNetCore.Mvc;

namespace QuickDish.Controllers
{
    [ApiController]
    [Route("api/health")]
    public class HealthController(ILogger<HealthController> logger): ControllerBase
    {
        private readonly ILogger<HealthController> _logger = logger;
        [HttpGet]
        public IActionResult GetHealth()
        {
            _logger.LogInformation("Server is working");
            return Ok(new { status = "OK", timestamp = DateTime.UtcNow });
        }
    }
}