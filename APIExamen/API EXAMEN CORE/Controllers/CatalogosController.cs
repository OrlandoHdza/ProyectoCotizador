using APIEXAMEN.Entidades;
using APIEXAMEN.Entidades.Catalogos;
using APIEXAMEN.Modelos.Catalogos;
using APIEXAMEN.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace API_EXAMEN_CORE.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CatalogosController : ControllerBase
    {
        private readonly IOptions<AppSetting> appsettings;
        Examen Implementacion;
        public CatalogosController(IOptions<AppSetting> _appsettings)
        {
            appsettings = _appsettings;
            Implementacion = new Examen(appsettings);  
        }


        [HttpGet("api/RegistrarTXT")]
        [Produces("application/json")]
        public Task<string> configuracionInicial() 
        {
            string datos = string.Empty;
            try
            {
                return Implementacion.RegustrarInformacionTxt();
            }
            catch (Exception)
            {
                datos = null;
                return Task.FromResult<string>(datos);
            }
        }


        [HttpGet("api/GetMarcas")]
        [Produces("application/json")]
        public Task<List<Marca>> ObtenerMarcas()
        {
            List<Marca> lsmarca = new List<Marca>();
            try
            {
                return Implementacion.GetAllMarca();
            }
            catch (Exception)
            {
                lsmarca = null;
                return Task.FromResult<List<Marca>>(lsmarca);
            }
        }

        [HttpGet("api/GetSubMarcas")]
        [Produces("application/json")]
        public Task<List<Submarca>> GetAllSubmarca([FromQuery] int MarcaID) 
        {
            List<Submarca> lssubmarca = new List<Submarca>();
            try
            {
                return Implementacion.GetAllSubmarca( MarcaID);
            }
            catch (Exception)
            {
                lssubmarca = null;
                return Task.FromResult<List<Submarca>>(lssubmarca);
                
            }
        }

        [HttpGet("api/GetModelos")]
        [Produces("application/json")]
        public Task<List<Modelo>> GetAllModelo([FromQuery] int SubmarcaID) 
        {
            List<Modelo> lsmodelo = new List<Modelo>();
            try
            {
                return Implementacion.GetAllModelo(SubmarcaID);
            }
            catch (Exception)
            {
                lsmodelo = null;
                return Task.FromResult<List<Modelo>>(lsmodelo);
               
            }
        }

        [HttpGet("api/GetDescripcion")]
        [Produces("application/json")]
        public Task<List<Descripciones>> GetAllDescripcion([FromQuery]int ModeloID, [FromQuery]int SubmarcaID) 
        {
            List<Descripciones> lsdescripcion = new List<Descripciones>();
            try
            {
                return Implementacion.GetAllDescripcion(ModeloID, SubmarcaID);
            }
            catch (Exception)
            {
                lsdescripcion = null;
                return Task.FromResult<List<Descripciones>>(lsdescripcion);
               
            }
        }
    }
}
