using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAssembly.Entidades.Catalogos
{
    public class MotivosContenido
    {
        private string llave = string.Empty;
        [JsonProperty("sLlave")]
        public string Llave { get => llave; set => llave = value; }

        private string dato = string.Empty;
        [JsonProperty("sDato")]
        public string Dato { get => dato; set => dato = value; }

        private string agrupador = string.Empty;
        [JsonProperty("sAgrupador")]
        public string Agrupador { get => agrupador; set => agrupador = value; }
    }
}
