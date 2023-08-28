using AeCChallenge.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeCChallenge.Infrastructure.Configuration.Tables
{
    public class CityWeatherEntityConfiguration : BaseTableConfiguration<CityWeather>
    {
        public override void Configure(EntityTypeBuilder<CityWeather> builder)
        {
            builder.Property(x => x.atualizado_em)
                .IsRequired();
            builder.Property(x => x.cidade)
                .IsRequired();
            builder.Property(x => x.clima_data)
                .IsRequired();
            builder.Property(x => x.estado)
                .IsRequired();
        }
    }
}
