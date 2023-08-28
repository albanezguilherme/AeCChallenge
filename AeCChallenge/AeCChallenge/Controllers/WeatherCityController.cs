using AeCChallenge.Core.Entities;
using AeCChallenge.Core.Interfaces.Services;
using AeCChallenge.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;

namespace AeCChallenge.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class WeatherCityController : ControllerBase
    {
        private readonly ICityWeatherService _cityWeatherService;

        public WeatherCityController(ICityWeatherService cityWeatherService)
        {
            _cityWeatherService = cityWeatherService;
        }

        [HttpGet]
        public ActionResult GetCityWeather(string cityCode)
        {
            try
            {
                var result = _cityWeatherService.GetCityWeather(cityCode);

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
