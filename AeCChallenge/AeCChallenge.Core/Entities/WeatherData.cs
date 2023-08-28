using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeCChallenge.Core.Entities
{
    public class WeatherData : BaseEntity
    {
        public string data { get; set; } = "";
        public string condicao { get; set; } = "";
        public int min { get; set; }
        public int max { get; set; }
        public int indice_uv { get; set; }
        public string condicao_desc { get; set; } = "";
    }
}
