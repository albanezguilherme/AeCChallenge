using AeCChallenge.Core.Entities;
using AeCChallenge.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeCChallenge.Infrastructure.Repositories
{
    public class AirportWeatherRepository : GenericRepository<AirportWeather>, IAirportWeatherRepository
    {
        public AirportWeatherRepository(AeCChallengeContext context) : base(context)
        {
        }
    }
}
