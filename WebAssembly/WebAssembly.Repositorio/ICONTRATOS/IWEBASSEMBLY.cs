using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAssembly.Entidades.Catalogos;
using WebAssembly.Entidades.CodigoPostal;

namespace WebAssembly.Repositorio.ICONTRATOS
{
    public interface IWEBASSEMBLY
    {
        Task<ObservableCollection<Marca>> GetContenidoMarca();
        Task<ObservableCollection<Submarca>> GetSubMarca(int MarcaId);

        Task<ObservableCollection<Modelos>> GetModelos(int SubmarcaId);

        Task<ObservableCollection<Descripciones>> GetDescripciones(int ModeloId, int SubmarcaId);

        Task<DatosUbicacion> ConlsultarSepomex(string CodigoP);


    }
}
