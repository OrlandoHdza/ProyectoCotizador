using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAssembly.Entidades.Catalogos
{
    public class Descripciones
    {
        private int id = 0;
        [JsonProperty("Id")]
        public int Id { get => id; set => id = value; }

        private int submarcaId = 0;
        [JsonProperty("SubmarcaId")]
        public int SubmarcaId { get => submarcaId; set => submarcaId = value; }

        private string descripcion = string.Empty;
        [JsonProperty("Descripcion")]
        public string Descripcion { get => descripcion; set => descripcion = value; }

        private string descripcionId = string.Empty;
        [JsonProperty("DescripcionId")]
        public string DescripcionId { get => descripcionId; set => descripcionId = value; }
    }
}
