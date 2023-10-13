using AutoMapper;
using SuministroProvisiones.Commons.Models;
using SuministroProvisiones.DOMAIN.Entities;

namespace SuministroProvisiones.Infrastructure.Configuration
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<SolicitudSuministro, SolicitudSuministroDto>()
                .ReverseMap();

            CreateMap<SolicitudSuministroResponse, SolicitudSuministroResponseDto>()
                .ReverseMap();
        }
    }
}
