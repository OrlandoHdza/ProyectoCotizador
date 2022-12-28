using Newtonsoft.Json;
using System.Text;

namespace WebAssembly.Herramientas
{
    public class GenericAPI
    {
        private string ConnectionAPIREST;
        public GenericAPI(string connectionAPIWeb)
        {
            ConnectionAPIREST = connectionAPIWeb;
        }

        public async Task<U> SimplePost<T, U>(T Parametros)
        {
            try
            {
                var serviceResult = default(U);

                using (var client = new HttpClient(new HttpClientHandler(), false))
                {
                    client.DefaultRequestHeaders.Clear();
                    client.Timeout = new TimeSpan(hours: 0, minutes: 0, seconds: 60);

                    HttpResponseMessage res = client.PostAsync(ConnectionAPIREST, SerializeObjectToJson(Parametros)).Result;

                    string response = await res.Content.ReadAsStringAsync();

                    if (res.IsSuccessStatusCode)
                    {
                        serviceResult = JsonConvert.DeserializeObject<U>(response);
                    }
                    else
                    {
                        throw new Exception(response);
                    }
                }
                return serviceResult;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<U> SimpleGet<U>()
        {
            try
            {
                var serviceResult = default(U);

                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Clear();
                    client.Timeout = new TimeSpan(hours: 0, minutes: 0, seconds: 60);

                    HttpResponseMessage res = await client.GetAsync(ConnectionAPIREST);

                    string response = await res.Content.ReadAsStringAsync();

                    if (res.IsSuccessStatusCode)
                    {
                        serviceResult = JsonConvert.DeserializeObject<U>(response);
                    }
                    else
                    {
                        throw new Exception(response);
                    }
                }
                return serviceResult;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private StringContent SerializeObjectToJson<T>(T properties)
        {
            var dataJson = JsonConvert.SerializeObject(properties);
            return new StringContent(dataJson, Encoding.UTF8, "application/json");
        }
    }
}