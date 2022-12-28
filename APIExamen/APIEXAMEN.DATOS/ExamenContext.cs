using APIEXAMEN.Modelos.Catalogos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIEXAMEN.DATOS
{
    public class ExamenContext : DbContext
    {
        public ExamenContext(string ConnectionString) : base(GetContext(ConnectionString))
        {

        }

        public static DbContextOptions GetContext(string ConnectionString) 
        {
            return new DbContextOptionsBuilder().UseSqlServer(ConnectionString).Options;
        }

        #region Required
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbDatos>().HasKey(x => x.Id);

            modelBuilder.Entity<TBMarca>().HasKey(m => m.Id);

            modelBuilder.Entity<TbSubmarca>().HasKey(s => s.Id);

            modelBuilder.Entity<TbModelo>().HasKey(M => M.Id);

            modelBuilder.Entity<TbDescripcion>().HasKey(d => d.Id);
    
            base.OnModelCreating(modelBuilder);
        }
        #endregion

        public DbSet<TbDatos> TbDatos { get; set; }
        public DbSet<TbDescripcion> TbDesxcripcion { get; set; }
        public DbSet<TBMarca> TBMarca { get; set; }
        public DbSet<TbModelo> TbModelo { get; set; }
        public DbSet<TbSubmarca> TbSubmarca { get; set; }




    }
}
