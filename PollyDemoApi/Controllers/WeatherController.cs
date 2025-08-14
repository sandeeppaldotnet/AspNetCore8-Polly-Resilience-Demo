using Microsoft.AspNetCore.Mvc;
using PollyDemoApi.Services;
using System.Threading.Tasks;

namespace PollyDemoApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherController : ControllerBase
    {
        private readonly IWeatherService _weatherService;
        public WeatherController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = await _weatherService.GetWeatherAsync();
                return Ok(result);
            }
            catch (System.Exception ex)
            {
                return StatusCode(503, $"Service is unavailable. Details: {ex.Message}");
            }
        }
    }
}
