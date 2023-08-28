using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AeCChallenge.Core.Entities
{
    public class CityWeather : BaseEntity
    {
        public string cidade { get; set; } = "";
        public string estado { get; set; } = "";
        public string atualizado_em { get; set; } = "";

        [NotMapped]
        public List<WeatherData> clima { get; set; }
        
        [JsonIgnore]
        public string clima_data { get; set; } = "";
    }
}
