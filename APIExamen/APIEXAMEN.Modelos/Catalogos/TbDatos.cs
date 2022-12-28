using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIEXAMEN.Modelos.Catalogos
{
    [Table("tbDatos")]
    public class TbDatos
    {

        private int id = 0;
        [Column("Id")]
        public int Id { get => id; set => id = value; }

        private string marca = string.Empty;
        [Column("Marca")]
        public string Marca { get => marca; set => marca = value; }

        private string submarca = string.Empty;
        [Column("Submarca")]
        public string Submarca { get => submarca; set => submarca = value; }

        private string modelo = string.Empty;
        [Column("Modelo")]
        public string Modelo { get => modelo; set => modelo = value; }

        private string descripcion = string.Empty;
        [Column("Descripcion")]
        public string Descripcion { get => descripcion; set => descripcion = value; }

        private string descripcionID = string.Empty;
        [Column("DescripcionID")]
        public string DescripcionID { get => descripcionID; set => descripcionID = value; }
    }
}
