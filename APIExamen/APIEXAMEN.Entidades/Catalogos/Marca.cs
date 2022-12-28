using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIEXAMEN.Entidades.Catalogos
{
    public class Marca
    {
        private int id = 0;
        public int Id { get => id; set => id = value; }

        private string nombre = string.Empty;
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
