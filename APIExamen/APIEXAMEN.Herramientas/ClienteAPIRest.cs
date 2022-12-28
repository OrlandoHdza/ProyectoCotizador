using APIEXAMEN.Entidades.Catalogos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace APIEXAMEN.Herramientas
{
    public class ClienteAPIRest
    {
        private string ConnectionApi; 
        public ClienteAPIRest(string connectionApi)
        {
            ConnectionApi = connectionApi; 
        }

        public Task<List<Datos>> SimpleGet() 
        {
            List<Datos> ListDatos = new List<Datos>();

            try
            {
                var serviceResult = default(List<Datos>);
                using (var client = new HttpClient(new HttpClientHandler(), false))
                {
                    client.DefaultRequestHeaders.Clear();
                    client.Timeout = new TimeSpan(hours: 0, minutes: 0, seconds: 60);

                    HttpResponseMessage respons = client.GetAsync(ConnectionApi).Result;

                    var strTxt = respons.Content.ReadAsStreamAsync().Result;

                    using (StreamReader str = new StreamReader(strTxt)) 
                    {
                        var prueba = new List<object>();
                        string line;
                        while ((line = str.ReadLine()) != null) 
                        {
                            string[] separacion = line.Split("\t");

                            Datos dato = new Datos();

                            dato.Marca = separacion[0].ToString();
                            dato.Submarca = separacion[1].ToString();
                            dato.Modelo = separacion[2].ToString();
                            dato.Descripcion = separacion[3].ToString();
                            dato.DescripcionID = separacion[4].ToString();

                            ListDatos.Add(dato);

                        }
                        serviceResult = ListDatos;
                    }
                    return Task.FromResult<List<Datos>>(serviceResult);
                }
            }
            catch (Exception)
            {
                throw;
            }


        }
    }
}
