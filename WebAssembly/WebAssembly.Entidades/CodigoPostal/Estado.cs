using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAssembly.Entidades.CodigoPostal
{
    public class Estado
    {
        [JsonProperty("iIdEstado")]
        public int IdEstado { get; set; } = 0;

        [JsonProperty("Pais")]
        public string Pais { get; set; } = string.Empty;

        [JsonProperty("iEstadoPais")]
        public int EstadoPais { get; set; } = 0;

        [JsonProperty("iClaveEstadoCepomex")]
        public int ClaveEstadoCepomex { get; set; } = 0;

        [JsonProperty("sEstado")]
        public string Nombre { get; set; } = string.Empty;

    }
}
