using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAssembly.Entidades.Catalogos
{
    public class SEPOMEX
    {
        private string catalogojson = string.Empty;
        [JsonProperty("CatalogoJsonString")]
        public string CatalogoJsonString { get => catalogojson; set => catalogojson = value; }

        private ErrorContenido? error;
        [JsonProperty("Error")]
        public ErrorContenido? Error { get => error; set => error = value; }
    }
}
