using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAssembly.Entidades.Catalogos
{
    public class Marca
    {
        private int id = 0;
        [JsonProperty("Id")]
        public int Id { get => id; set => id = value; }

        private string nombre = string.Empty;
        [JsonProperty("Nombre")]
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
