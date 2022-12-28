using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAssembly.Datos;
using WebAssembly.Entidades.Catalogos;
using WebAssembly.Entidades.CodigoPostal;
using WebAssembly.Repositorio.ICONTRATOS;

namespace WebAssembly.Repositorio.CONTRATOS
{
    public class ASSEMBLY : IWEBASSEMBLY
    {
        public async Task<ObservableCollection<Marca>> GetContenidoMarca()
        {
            ObservableCollection<Marca> marcasContenidos = new ObservableCollection<Marca>();

            try
			{
				APIWebData webData = new APIWebData("https://localhost:7297/Catalogos/api/GetMarcas");

                marcasContenidos = await webData.GetContenidoMarca();
			}
			catch (Exception)
			{
				throw;
			}

            return marcasContenidos;
        }

        public async Task<ObservableCollection<Modelos>> GetModelos(int SubmarcaId)
        {
            ObservableCollection<Modelos> modelosContenido = new ObservableCollection<Modelos>();

            try
            {
                APIWebData webData = new APIWebData("https://localhost:7297/Catalogos/api/GetModelos");

                modelosContenido = await webData.GetModelos(SubmarcaId);
            }
            catch (Exception)
            {

                throw;
            }

            return modelosContenido;
        }

        public async Task<ObservableCollection<Submarca>> GetSubMarca(int MarcaId)
        {
            ObservableCollection<Submarca> submarcaContenido = new ObservableCollection<Submarca>();

            try
			{
                APIWebData webData = new APIWebData("https://localhost:7297/Catalogos/api/GetSubMarcas");

                submarcaContenido = await webData.GetSubMarca(MarcaId);

            }
			catch (Exception)
			{
				throw;
			}

            return submarcaContenido;
        }

        public async Task<ObservableCollection<Descripciones>> GetDescripciones(int ModeloId, int SubmarcaId) 
        {
            ObservableCollection<Descripciones> descripciones = new ObservableCollection<Descripciones>();

            try
            {
                APIWebData webDta = new APIWebData("https://localhost:7297/Catalogos/api/GetDescripcion");

                descripciones = await webDta.GetDescripciones(SubmarcaId, ModeloId);
            }
            catch (Exception)
            {

                throw;
            }

            return descripciones;
        }

        public async Task<DatosUbicacion> ConlsultarSepomex(string CodigoP)
        {
            DatosUbicacion datos = null;
            try
            {
                List<Ubicacion> Tempubicaciones = new List<Ubicacion>();

                APIWebData webDta = new APIWebData("https://api-test.aarco.com.mx/api-examen/api/examen/sepomex/");

                var resultado = await webDta.ConlsultarSepomex(CodigoP);

                foreach (var i in resultado)
                {
                    datos = new DatosUbicacion();
                    datos.Estado = i.municipio.ESTADO.Nombre;
                    datos.Municipio = i.municipio.Nombre;

                    foreach (var it in i.ubicacion)
                    {
                        Tempubicaciones.Add(it);
                    }
                }

                datos.Ubicaciones = new List<Ubicacion>(Tempubicaciones);
            }
            catch (Exception)
            {
                datos = null;
                throw;
            }
            return datos;
        }
    }
}
