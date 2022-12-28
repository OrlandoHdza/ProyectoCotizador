using APIEXAMEN.Entidades.Catalogos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIEXAMEN.Repositorio
{
    public interface IEXAMEN
    {
        Task<string> RegustrarInformacionTxt();

        Task<List<Marca>> GetAllMarca();

        Task<List<Submarca>> GetAllSubmarca(int MarcaID);

        Task<List<Modelo>> GetAllModelo(int SubmarcaID);

        Task<List<Descripciones>> GetAllDescripcion(int SUbmarcaID, int ModeloID);
    }
}
