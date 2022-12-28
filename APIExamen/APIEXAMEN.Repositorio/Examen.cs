using APIEXAMEN.Entidades;
using APIEXAMEN.Entidades.Catalogos;
using APIEXAMEN.Negocio;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIEXAMEN.Repositorio
{
    public class Examen : IEXAMEN
    {
        private readonly IOptions<AppSetting> appsettings;

        public Examen(IOptions<AppSetting> _appsettings)
        {
            appsettings = _appsettings;
        }

        public Task<List<Descripciones>> GetAllDescripcion(int SubmarcaID, int ModeloID)
        {
            List<Descripciones> descripcionesResult = new List<Descripciones>();
            try
            {
                NegocioCatalogo negocio = new NegocioCatalogo(appsettings);

                descripcionesResult = negocio.GetDescripciones(SubmarcaID, ModeloID);

            }
            catch (Exception)
            {

                throw;
            }
            return Task.FromResult<List<Descripciones>>(descripcionesResult);
        }

        public Task<List<Marca>> GetAllMarca()
        {
            List<Marca> marcaResult = new List<Marca>();
            try
            {
                NegocioCatalogo negocio = new NegocioCatalogo(appsettings);

                marcaResult = negocio.GetMarca();
            }
            catch (Exception)
            {
                throw;
            }

            return Task.FromResult<List<Marca>>(marcaResult);

        }

        public Task<List<Modelo>> GetAllModelo(int SubmarcaID)
        {
            List<Modelo> modeloResult = new List<Modelo>();
            try
            {
                NegocioCatalogo negocio = new NegocioCatalogo(appsettings);

                modeloResult = negocio.GetModelo(SubmarcaID);

            }
            catch (Exception)
            {

                throw;
            }
            return Task.FromResult<List<Modelo>>(modeloResult);
        }

        public Task<List<Submarca>> GetAllSubmarca(int MarcaID)
        {
            List<Submarca> submarcaResult = new List<Submarca>();
            try
            {
                NegocioCatalogo negocio = new NegocioCatalogo(appsettings);

                submarcaResult = negocio.GetSubmarca(MarcaID);
            }
            catch (Exception)
            {
                throw;
            }
            return Task.FromResult<List<Submarca>>(submarcaResult);
        }

        public Task<string> RegustrarInformacionTxt()
        {
            string resultado = string.Empty;
            try
            {
                NegocioCatalogo negocio = new NegocioCatalogo(appsettings);

                int datos = negocio.RegistrodeDatos();

                resultado = datos != 0 ? "Registro Exitoso" : "No se pudo registrar";

            }
            catch (Exception)
            {
                throw;
            }

            return Task.FromResult<string>(resultado);

        }
    }
}
