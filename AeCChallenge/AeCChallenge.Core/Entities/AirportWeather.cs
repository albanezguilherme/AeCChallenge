using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeCChallenge.Core.Entities
{
    [Table("AirportWeathers")]
    public class AirportWeather : BaseEntity
    {
        public string codigo_icao { get; set; } = "";
        public string atualizado_em { get; set; } = "";
        public int pressao_atmosferica { get; set; }
        public string visibilidade { get; set; } = "";
        public int vento { get; set; }
        public int direcao_vento { get; set; }
        public int umidade { get; set; }
        public string condicao { get; set; } = "";
        public string condicao_Desc { get; set; } = "";
        public int temp { get; set; }
    }
}
