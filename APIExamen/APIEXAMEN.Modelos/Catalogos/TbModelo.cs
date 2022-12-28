using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIEXAMEN.Modelos.Catalogos
{
    [Table("tbModelos")]
    public class TbModelo
    {
        private int id = 0;
        [Column("id")]
        public int Id { get => id; set => id = value; }

        private int submarcaID = 0;
        [Column("SubmarcaID")]
        public int SubmarcaID { get => submarcaID; set => submarcaID = value; }

        private string anio = string.Empty;
        [Column("Anio")]
        public string Anio { get => anio; set => anio = value; }

    }
}
