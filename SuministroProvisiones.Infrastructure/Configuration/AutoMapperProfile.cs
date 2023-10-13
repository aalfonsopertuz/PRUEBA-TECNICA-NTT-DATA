using AutoMapper;
using SuministroProvisiones.DOMAIN.Entities;

namespace SuministroProvisiones.Infrastructure.Configuration
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<SolicitudSuministro, SolicitudSuministroDto>();
        }
    }
}
