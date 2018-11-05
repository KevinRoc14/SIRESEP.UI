using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;

namespace SIRESEP.UI
{
    public static class AutoMapperConfig
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Models.Carrera, DATOS.Carrera>();
                cfg.CreateMap<DATOS.Carrera, Models.Carrera>();

                cfg.CreateMap<Models.Certificaciones, DATOS.Certificaciones>();
                cfg.CreateMap<DATOS.Certificaciones, Models.Certificaciones>();

                cfg.CreateMap<Models.InfoPuesto, DATOS.InfoPuesto>();
                cfg.CreateMap<DATOS.InfoPuesto, Models.InfoPuesto>();

                cfg.CreateMap<Models.InfoGenero, DATOS.InfoGenero>();
                cfg.CreateMap<DATOS.InfoGenero, Models.InfoGenero>();

                cfg.CreateMap<Models.InfoGradoEstudio, DATOS.InfoGradoEstudio>();
                cfg.CreateMap<DATOS.InfoGradoEstudio, Models.InfoGradoEstudio>();

                cfg.CreateMap<Models.InfoHabilidad, DATOS.InfoHabilidad>();
                cfg.CreateMap<DATOS.InfoHabilidad, Models.InfoHabilidad>();

                cfg.CreateMap<Models.Estado, DATOS.Estado>();
                cfg.CreateMap<DATOS.Estado, Models.Estado>();

                cfg.CreateMap<Models.InfoIdioma, DATOS.InfoIdioma>();
                cfg.CreateMap<DATOS.InfoIdioma, Models.InfoIdioma>();

                cfg.CreateMap<Models.InfoInstitucion, DATOS.InfoInstitucion>();
                cfg.CreateMap<DATOS.InfoInstitucion, Models.InfoInstitucion>();

                cfg.CreateMap<Models.InfoLaboral, DATOS.InfoLaboral>();
                cfg.CreateMap<DATOS.InfoLaboral, Models.InfoLaboral>();

                cfg.CreateMap<Models.InfoLicenciaConducir, DATOS.InfoLicenciaConducir>();
                cfg.CreateMap<DATOS.InfoLicenciaConducir, Models.InfoLicenciaConducir>();

                cfg.CreateMap<Models.InfoNacionalidad, DATOS.InfoNacionalidad>();
                cfg.CreateMap<DATOS.InfoNacionalidad, Models.InfoNacionalidad>();
            });
        }
    }
}