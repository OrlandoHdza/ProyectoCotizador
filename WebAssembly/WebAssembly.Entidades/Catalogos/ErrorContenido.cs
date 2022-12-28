using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAssembly.Entidades.Catalogos
{
    public class ErrorContenido
    {
        private string numero = string.Empty;
        [JsonProperty("Numero")]
        public string Nombre { get => numero; set => numero = value; }

        private string descripcion = string.Empty;
        [JsonProperty("Descripcion")]
        public string Descripcion { get => descripcion; set => descripcion = value; }

    }
}
