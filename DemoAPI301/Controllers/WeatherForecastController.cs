using Microsoft.AspNetCore.Mvc;

namespace DemoAPI301.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 10).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
        [HttpPost("get-villain")]
        public IEnumerable<string> GetVillain() {
            return new List<string>()
            {
                "Crying god", "Remmember Link", "Loose House",
                "King of Muzik", "Villa How", "Dark Nh�n t�m"
            };
        }
        [HttpGet("calculate-interest")]
        public double GetInterest(int day, int money, double percent)
        {
            return money * Math.Pow((1 + percent / 100), day) - money;
        }
    }
}