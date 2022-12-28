using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace APIEXAMEN.Entidades.Catalogos
{
    public class Descripciones
    {
        private int id = 0;
        public int Id { get => id; set => id = value; }

        private int submarcaID = 0;
        public int SubmarcaID { get => submarcaID; set => submarcaID = value; }

        private string descripcion = string.Empty;
        public string Descripcion { get => descripcion; set => descripcion = value; }

        private string descripcionID = string.Empty;
        public string DescripcionID { get => descripcionID; set => descripcionID = value; }

        private int modeloid = 0;
        public int ModeloId { get => modeloid; set => modeloid = value; }
    }
}
