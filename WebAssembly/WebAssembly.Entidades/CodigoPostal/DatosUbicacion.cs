using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAssembly.Entidades.CodigoPostal
{
    public class DatosUbicacion
    {
        public string Estado { get; set; } 
        public string Municipio { get; set; }
        public List<Ubicacion> Ubicaciones { get; set; }
    }
}
