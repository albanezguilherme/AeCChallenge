using AeCChallenge.Core.Entities;
using AeCChallenge.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeCChallenge.Infrastructure.Repositories
{
    public class CityWeatherRepository : GenericRepository<CityWeather>, ICityWeatherRepository
    {
        public CityWeatherRepository(AeCChallengeContext context) : base(context)
        {
        }
    }
}
