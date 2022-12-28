using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIEXAMEN.Entidades.Catalogos
{
    public class Modelo
    {
        private int id = 0;
        public int Id { get => id; set => id = value; }

        private int submarcaID = 0;
        public int SubmarcaID { get => submarcaID; set => submarcaID = value; }

        private string anio = string.Empty;
        public string Anio { get => anio; set => anio = value; }
    }
}
