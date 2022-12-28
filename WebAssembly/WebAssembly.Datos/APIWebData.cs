using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using WebAssembly.Entidades.Catalogos;
using WebAssembly.Entidades.CodigoPostal;
using WebAssembly.Herramientas;

namespace WebAssembly.Datos
{
    public class APIWebData
    {
        private GenericAPI? APICliente;

        private string ConnectionAPIREST;
        public APIWebData(string connectionAPIREST)
        {
            ConnectionAPIREST = connectionAPIREST;
        }


        public async Task<ObservableCollection<Marca>> GetContenidoMarca()
        {
            ObservableCollection<Marca> marcabase = new ObservableCollection<Marca>();

            try
            {
                APICliente = new GenericAPI(ConnectionAPIREST);

                var response = await APICliente.SimpleGet<List<Marca>>();

                if (response != null)
                {
                    foreach (var i in response)
                    {
                        marcabase.Add(i);
                    }
                }
            }
            catch (Exception ex)
            {
                var Error = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw;
            }

            return marcabase;

        }


        public async Task<ObservableCollection<Submarca>> GetSubMarca(int MarcaId)
        {
            ObservableCollection<Submarca> submarcasbase = new ObservableCollection<Submarca>();
            try
            {
                string UrlParam = string.Concat(ConnectionAPIREST, "?MarcaID=", MarcaId.ToString());

                APICliente = new GenericAPI(UrlParam);


                var response = await APICliente.SimpleGet<List<Submarca>>();

                if (response != null)
                {
                    foreach (var i in response)
                    {
                        submarcasbase.Add(i);
                    }
                }

            }
            catch (Exception ex)
            {
                var Error = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw;
            }

            return submarcasbase;
        }

       public async Task<ObservableCollection<Modelos>> GetModelos(int SubmarcaId) 
        {
            ObservableCollection<Modelos> modelos = new ObservableCollection<Modelos>();

            try
            {
                string Url = string.Concat(ConnectionAPIREST, "?SubmarcaID=", SubmarcaId.ToString());

                APICliente = new GenericAPI(Url);

                var response = await APICliente.SimpleGet<List<Modelos>>();

                if (response != null) 
                {
                    foreach (var i in response) 
                    {
                        modelos.Add(i);
                    }
                }

            }
            catch (Exception ex)
            {
                var Erro = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw;
                
            }

            return modelos;
        }

        public async Task<ObservableCollection<Descripciones>> GetDescripciones(int SubmarcaId, int ModeloId) 
        {
            ObservableCollection<Descripciones> descripciones = new ObservableCollection<Descripciones>();

            try
            {
                string Url = string.Concat(ConnectionAPIREST, "?ModeloID=", ModeloId.ToString(), "&&SubmarcaID=", SubmarcaId.ToString());

                APICliente= new GenericAPI(Url);

                var response = await APICliente.SimpleGet<List<Descripciones>>();

                if (response != null) 
                {
                    foreach(var i in response) 
                    {
                        descripciones.Add(i);
                    }
                }

            }
            catch (Exception ex)
            {

                var Error = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw;
            }

            return descripciones;
        }

        public async Task<List<CatalogoSEPOMEX>> ConlsultarSepomex(string CodigoP) 
        {
            string sepomex = string.Empty;
            List<CatalogoSEPOMEX> catsepo = new List<CatalogoSEPOMEX>();


            try
            {
                string Url = string.Concat(ConnectionAPIREST, CodigoP);

                APICliente = new GenericAPI(Url);

                var responser = await APICliente.SimpleGet<SEPOMEX>();

                if ( responser.Error == null ) 
                {
                    sepomex = responser.CatalogoJsonString;

                    catsepo = JsonConvert.DeserializeObject<List<CatalogoSEPOMEX>>(sepomex);
                }
            }
            catch (Exception ex)
            {
                var Error = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw;
            }

            return catsepo;
        }

    }
}