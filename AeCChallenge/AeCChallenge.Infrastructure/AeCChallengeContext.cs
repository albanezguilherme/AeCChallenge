using AeCChallenge.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeCChallenge.Infrastructure
{
    public class AeCChallengeContext : DbContext
    {
        public AeCChallengeContext(DbContextOptions<AeCChallengeContext> options) : base(options) { }

        public DbSet<AirportWeather> AirportWeathers { get; set; }
        public DbSet<CityWeather> CityWeathers{ get; set; }
    }
}
