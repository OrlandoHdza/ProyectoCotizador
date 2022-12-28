using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAssembly.Entidades.CodigoPostal
{
    public class CatalogoSEPOMEX
    {
        [JsonProperty("Municipio")]
        public Municipio? municipio { get; set; }

        [JsonProperty("Ubicacion")]
        public List<Ubicacion>? ubicacion { get; set; }

    }
}
