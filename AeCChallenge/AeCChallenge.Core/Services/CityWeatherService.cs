using AeCChallenge.Core.Entities;
using AeCChallenge.Core.Helpers;
using AeCChallenge.Core.Interfaces.Repositories;
using AeCChallenge.Core.Interfaces.Services;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AeCChallenge.Core.Services
{
    public class CityWeatherService : ICityWeatherService
    {
        ICityWeatherRepository _cityWeatherRepository;

        public CityWeatherService(ICityWeatherRepository cityWeatherRepository)
        {
            _cityWeatherRepository = cityWeatherRepository;
        }

        public CityWeather GetCityWeather(string cityCode)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://brasilapi.com.br/api/cptec/v1/clima/previs/");
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var jsonResult = client.GetAsync(cityCode).Result.Content.ReadAsStringAsync().Result;
                    if (JsonValidation.ValidateJson(jsonResult))
                    {
                        return null;
                    }

                    var result = JsonSerializer.Deserialize<CityWeather>(jsonResult);
                    result.clima_data = JsonSerializer.Serialize(result.clima);
                    _cityWeatherRepository.Add(result);

                    return result;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                throw;
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }
    }
}
