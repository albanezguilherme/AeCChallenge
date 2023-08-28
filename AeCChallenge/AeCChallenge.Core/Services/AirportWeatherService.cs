using AeCChallenge.Core.Entities;
using AeCChallenge.Core.Helpers;
using AeCChallenge.Core.Interfaces.Repositories;
using AeCChallenge.Core.Interfaces.Services;
using Serilog;
using System.Net.Http.Headers;
using System.Text.Json;

namespace AeCChallenge.Core.Services
{
    public class AirportWeatherService : GenericService<AirportWeather>, IAirportWeatherService
    {
        private readonly IAirportWeatherRepository _airportRepository;

        public AirportWeatherService(IAirportWeatherRepository genericRepository) : base(genericRepository)
        {
            _airportRepository = genericRepository;
        }

        public object GetAirportWeather(string airportCode)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://brasilapi.com.br/api/cptec/v1/clima/aeroporto/");
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var jsonResult = client.GetAsync(airportCode).Result.Content.ReadAsStringAsync().Result;
                    if (JsonValidation.ValidateJson(jsonResult))
                    {
                        return null;
                    }

                    var result = JsonSerializer.Deserialize<AirportWeather>(jsonResult);
                    _airportRepository.Add(result);

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
