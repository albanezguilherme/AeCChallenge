using AeCChallenge.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeCChallenge.Infrastructure.Configuration.Tables
{
    public class AirportWeatherEntityConfiguration : BaseTableConfiguration<AirportWeather>
    {
        public override void Configure(EntityTypeBuilder<AirportWeather> builder)
        {
            builder.Property(x => x.atualizado_em)
                .IsRequired();
            builder.Property(x => x.codigo_icao)
                .IsRequired();
            builder.Property(x => x.condicao)
                .IsRequired();
            builder.Property(x => x.condicao_Desc)
                .IsRequired();
            builder.Property(x => x.direcao_vento)
                .IsRequired();
            builder.Property(x => x.pressao_atmosferica)
                .IsRequired();
            builder.Property(x => x.temp)
                .IsRequired();
            builder.Property(x => x.umidade)
                .IsRequired();
            builder.Property(x => x.vento)
                .IsRequired();
            builder.Property(x => x.visibilidade)
                .IsRequired();
        }
    }
}
