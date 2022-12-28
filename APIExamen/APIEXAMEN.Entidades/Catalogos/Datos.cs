using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIEXAMEN.Entidades.Catalogos
{
    public class Datos
    {
        private string marca = string.Empty;
        public string Marca { get => marca; set => marca = value; }

        private string submarca = string.Empty;
        public string Submarca { get => submarca; set => submarca = value; }

        private string modelo = string.Empty;
        public string Modelo { get => modelo; set => modelo = value; }

        private string descripcion = string.Empty;
        public string Descripcion { get => descripcion; set => descripcion = value; }

        private string descripcionID = string.Empty;
        public string DescripcionID { get => descripcionID; set => descripcionID = value; }
    }
}
