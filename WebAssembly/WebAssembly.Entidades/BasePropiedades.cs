using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAssembly.Entidades
{
    public class BasePropiedades
    {
        private bool exito = false;
        [JsonProperty("Success")]
        public bool Exito { get => exito; set => exito = value; }

        private string mensaje = string.Empty;
        [JsonProperty("Message")]
        public string Mensaje { get => mensaje; set => mensaje = value; }

        private string token = string.Empty;
        [JsonProperty("Token")]
        public string Token { get => token; set => token = value; }

    }
}
