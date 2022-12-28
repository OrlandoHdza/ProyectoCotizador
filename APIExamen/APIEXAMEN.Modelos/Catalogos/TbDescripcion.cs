using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIEXAMEN.Modelos.Catalogos
{
    [Table("tbDescripcion")]
    public class TbDescripcion
    {
        private int id = 0;
        [Column("id")]
        public int Id { get => id; set => id = value; }
        
        private int submarcaID = 0;
        [Column("SubmarcaID")]
        public int SubmarcaID { get => submarcaID; set => submarcaID = value; }

        private string descripcion = string.Empty;
        [Column("Descripcion")]
        public string Descripcion { get => descripcion; set => descripcion = value; }

        private string descripcionID = string.Empty;
        [Column("DescripcionID")]
        public string DescripcionID { get => descripcionID; set => descripcionID = value; }

        private int modeloid = 0;
        [Column("ModeloId")]
        public int ModeloId { get => modeloid; set => modeloid = value; }
    }
}
