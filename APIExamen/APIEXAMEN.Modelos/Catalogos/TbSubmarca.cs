using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIEXAMEN.Modelos.Catalogos
{
    [Table("tbSubmarca")]
    public class TbSubmarca
    {
        private int id = 0;
        [Column("id")]
        public int Id { get => id; set => id = value; }

        private int marcaID = 0;
        [Column("MarcaID")]
        public int MarcaID { get => marcaID; set => marcaID = value; }

        private string nombre = string.Empty;
        [Column("Nombre")]
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
