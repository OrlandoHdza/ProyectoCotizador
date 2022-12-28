using APIEXAMEN.DATOS;
using APIEXAMEN.Entidades;
using APIEXAMEN.Entidades.Catalogos;
using APIEXAMEN.Herramientas;
using APIEXAMEN.Modelos.Catalogos;
using AutoMapper;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIEXAMEN.Negocio
{
    public class NegocioCatalogo
    {
        private readonly IOptions<AppSetting> appsettings;
        IMapper mapper = new CoreMapper().configuration.CreateMapper();

        public NegocioCatalogo(IOptions<AppSetting> _appsettings)
        {
            appsettings = _appsettings;
        }

        public int RegistrodeDatos()
        {
            int resultado = 0;
            try
            {
                string APIURL = appsettings.Value.ConnectionString["EXAMENBDLOC"];

                ClienteAPIRest? cliente = new ClienteAPIRest("https://web.aarco.com.mx/examen-insumos/ListaDeAutos.txt");

                var respons = cliente.SimpleGet().Result;

                if (respons != null)
                {
                    DAOCatalogo daoCatalogo = new DAOCatalogo(APIURL);

                    var modelMapper = mapper.Map<List<Datos>, List<TbDatos>>(respons);

                    resultado = daoCatalogo.insertardatos(modelMapper);
                }

                return resultado;

            }
            catch (Exception)
            {                
                throw;
            }
        }

        public List<Marca> GetMarca()
        {
            List<Marca> marca = new List<Marca>();
            try
            {
                string Connection = appsettings.Value.ConnectionString["EXAMENBDLOC"];

                DAOCatalogo daoCatalogo = new DAOCatalogo(Connection);

                var tbmarca = daoCatalogo.GetAllMarca();

                marca = mapper.Map<List<TBMarca>, List<Marca>>(tbmarca);

                return marca;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Submarca> GetSubmarca(int MarcaID) 
        {
            List<Submarca> submarca = new List<Submarca>();
            try
            {
                string Connection = appsettings.Value.ConnectionString["EXAMENBDLOC"];

                DAOCatalogo daoCatalogo = new DAOCatalogo(Connection);

                var tbsubmarca = daoCatalogo.GetAllSubmarca(MarcaID);

                submarca = mapper.Map<List<TbSubmarca>, List<Submarca>>(tbsubmarca);

                return submarca; 


            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Modelo> GetModelo(int SubmarcaID) 
        {
            List<Modelo> modelo = new List<Modelo>();
            try
            {
                string Connection = appsettings.Value.ConnectionString["EXAMENBDLOC"];

                DAOCatalogo daoCatalogo = new DAOCatalogo(Connection);

                var tbmodelo = daoCatalogo.GetAllModelo(SubmarcaID);
                modelo = mapper.Map<List<TbModelo>, List<Modelo>>(tbmodelo);

                return modelo;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Descripciones> GetDescripciones(int SubmarcaID, int ModeloID) 
        {
            List<Descripciones> descripcion = new List<Descripciones>();
            try
            {
                string Connection = appsettings.Value.ConnectionString["EXAMENBDLOC"];

                DAOCatalogo daoCatalogo = new DAOCatalogo(Connection);

                var tbdescripcion = daoCatalogo.GetAllDescripcion(SubmarcaID, ModeloID);
                descripcion = mapper.Map<List<TbDescripcion>, List<Descripciones>>(tbdescripcion);

                return descripcion; 
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
