using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAssembly.Entidades.CodigoPostal
{
    public class Municipio
    {
        [JsonProperty("iIdMunicipio")]
        public int IdMunicipio { get; set; } = 0;

        [JsonProperty("Estado")]
        public Estado? ESTADO { get; set; }

        [JsonProperty("iMunicipioEstado")]
        public int MunicipioEstado { get; set; } = 0;

        [JsonProperty("iClaveMunicipioCepomex")]
        public int ClaveMunicipioCepomex { get; set; } = 0;

        [JsonProperty("sMunicipio")]
        public string Nombre { get; set; } = string.Empty;
    }
}
