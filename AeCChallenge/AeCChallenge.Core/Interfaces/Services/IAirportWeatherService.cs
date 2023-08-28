using AeCChallenge.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeCChallenge.Core.Interfaces.Services
{
    public interface IAirportWeatherService : IGenericService<AirportWeather>
    {
        object GetAirportWeather(string airportCode);
    }
}
