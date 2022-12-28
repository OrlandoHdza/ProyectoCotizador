using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIEXAMEN.Entidades.Catalogos
{
    public class Submarca
    {
        private int id = 0;
        public int Id { get => id; set => id = value; }

        private int marcaID = 0;
        public int MarcaID { get => marcaID; set => marcaID = value; }

        private string nombre = string.Empty;
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
