using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAssembly.Entidades.Catalogos
{
    public class Modelos
    {
        private int id = 0;
        [JsonProperty("Id")]
        public int Id { get => id; set => id = value; }
        
        private int submarcaId = 0;
        [JsonProperty("SubmarcaId")]
        public int SubmarcaId { get => submarcaId; set => submarcaId = value; }

        private string anio = string.Empty;
        [JsonProperty("Anio")]
        public string Anio { get => anio; set => anio = value; }
    }
}
