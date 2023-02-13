using Microsoft.AspNetCore.Mvc;

namespace dpd_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculationController : ControllerBase
    {
        private readonly ILogger<CalculationController> _logger;

        public CalculationController(ILogger<CalculationController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetCalculation")]
        public IActionResult GetCalculation()
        {
            using HttpClient httpClient = new HttpClient();

            httpClient.BaseAddress = new Uri("https://api.dpd.ro/v1/");


            return Ok();
        }
    }
}