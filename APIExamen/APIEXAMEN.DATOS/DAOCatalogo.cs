using APIEXAMEN.Modelos.Catalogos;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace APIEXAMEN.DATOS
{
    public class DAOCatalogo
    {
        ExamenContext? ctxExamen;

        private string ConnectionString;
        public DAOCatalogo(string connectionString)
        {
          ConnectionString = connectionString;
        }


        public int insertardatos (List<TbDatos> modelo) 
        {
            int result = 0;
            try
            {
                ctxExamen = new ExamenContext(ConnectionString);

                if (modelo != null)
                {
                    ctxExamen.TbDatos.AddRange(modelo);
                    result = ctxExamen.SaveChanges();
                }
            }
            catch (Exception)
            {
                result = 0;
                throw;
            }
            return result;

        }


        public List<TBMarca> GetAllMarca()
        {
            List<TBMarca> lsMarca = new List<TBMarca>();
            try
            {
                ctxExamen = new ExamenContext(ConnectionString);

                lsMarca = ctxExamen.TBMarca.ToList();

                return lsMarca;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<TbSubmarca> GetAllSubmarca(int marcaID) 
        {
            List<TbSubmarca> lsSubmarca = new List<TbSubmarca>();
            try
            {
                ctxExamen = new ExamenContext(ConnectionString);

                lsSubmarca = ctxExamen.TbSubmarca.Where(x => x.MarcaID == marcaID).ToList();

                return lsSubmarca;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<TbModelo> GetAllModelo(int SubmarcaID) 
        {
            List<TbModelo> lsModelo = new List<TbModelo>();
            try
            {
                ctxExamen = new ExamenContext(ConnectionString);

                lsModelo = ctxExamen.TbModelo.Where(x => x.SubmarcaID == SubmarcaID).ToList();

                return lsModelo; 
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<TbDescripcion> GetAllDescripcion(int ModeloID, int SubmarcaID) 
        {
            List<TbDescripcion> lsDescripcion = new List<TbDescripcion>();
            try
            {
                ctxExamen = new ExamenContext(ConnectionString);

                lsDescripcion = ctxExamen.TbDesxcripcion.Where(x => x.SubmarcaID == SubmarcaID && x.ModeloId == ModeloID).ToList();

                return lsDescripcion;
            }
            catch (Exception)
            {
                throw;
            }
        }
 
    }

}