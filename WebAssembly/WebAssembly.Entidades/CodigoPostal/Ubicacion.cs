using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAssembly.Entidades.CodigoPostal
{
    public class Ubicacion
    {
        [JsonProperty("iIdUbicacion")]
        public int IdUbicacion { get; set; } = 0;

        [JsonProperty("CodigoPostal")]
        public string CodigoPostal { get; set; } = string.Empty;

        [JsonProperty("iUbicacionCodigoPostal")]
        public int UbicacionCodigoPostal { get; set; } = 0;

        [JsonProperty("TipoUbicacion")]
        public string TipoUbicacion { get; set; } = string.Empty;

        [JsonProperty("iClaveUbicacionCepomex")]
        public int ClaveUbicacionCepomex { get; set; } = 0;

        [JsonProperty("Ciudad")]
        public string Ciudad { get; set; } = string.Empty;

        [JsonProperty("sUbicacion")]
        public string Nombre { get; set; } = string.Empty;

    }
}
