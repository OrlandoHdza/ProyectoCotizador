using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAssembly.Entidades.Catalogos
{
    public class CatalogosBase<T> : BasePropiedades
    {
        [JsonProperty("motivos")]
        public T Motivos { get; set; }
    }
}
