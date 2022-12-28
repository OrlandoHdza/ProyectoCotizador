using APIEXAMEN.Entidades.Catalogos;
using APIEXAMEN.Modelos.Catalogos;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace APIEXAMEN.Negocio
{
    public class CoreMapper : Profile
    {
        private MapperConfiguration _config;
        public MapperConfiguration configuration { get => _config; set => _config = value; }

        public CoreMapper()
        {
            configuration = new MapperConfiguration(cfg => {

                cfg.CreateMap<TbDatos, Datos>()
                .ForMember(x => x.Marca, x => x.MapFrom(y => y.Marca))
                .ForMember(x => x.Submarca, x => x.MapFrom(y => y.Submarca))
                .ForMember(x => x.Modelo, x => x.MapFrom(y => y.Modelo))
                .ForMember(x => x.Descripcion, x => x.MapFrom(y => y.Descripcion))
                .ForMember(x => x.DescripcionID, x => x.MapFrom(y => y.DescripcionID));


                cfg.CreateMap<Datos, TbDatos>()
                .ForMember(x => x.Marca, x => x.MapFrom(y => y.Marca))
                .ForMember(x => x.Submarca, x => x.MapFrom(y => y.Submarca))
                .ForMember(x => x.Modelo, x => x.MapFrom(y => y.Modelo))
                .ForMember(x => x.Descripcion, x => x.MapFrom(y => y.Descripcion))
                .ForMember(x => x.DescripcionID, x => x.MapFrom(y => y.DescripcionID));


                cfg.CreateMap<TBMarca, Marca>();
                cfg.CreateMap<Marca, Marca>();

                cfg.CreateMap<TbSubmarca, Submarca>();
                cfg.CreateMap<Submarca, TbSubmarca>();

                cfg.CreateMap<TbModelo, Modelo>();
                cfg.CreateMap<Modelo, TbModelo>();

                cfg.CreateMap<TbDescripcion, Descripciones>();
                cfg.CreateMap<Descripciones, TbDescripcion>();




            });
        }

    }
}
