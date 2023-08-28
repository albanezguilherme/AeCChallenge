using AeCChallenge.Core.Entities;
using AeCChallenge.Core.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace AeCChallenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherAirportController : ControllerBase
    {
        private readonly IAirportWeatherService _airportWeatherService;

        public WeatherAirportController(IAirportWeatherService airportWeatherService)
        {
            _airportWeatherService = airportWeatherService;
        }

        [HttpGet]
        public ActionResult GetAirportWeather(string airportCode)
        {
            try
            {
                var result = _airportWeatherService.GetAirportWeather(airportCode);

                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                    return NotFound("Previsão não encontrada");
                }
            }
            catch (Exception)
            {
                return BadRequest();
            }            
        }
    }
}
