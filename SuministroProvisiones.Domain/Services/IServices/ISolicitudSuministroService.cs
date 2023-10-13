using SuministroProvisiones.Commons.Models;
using SuministroProvisiones.DOMAIN.Entities;

namespace SuministroProvisiones.Domain.Services.IServices
{
    public interface ISolicitudSuministroService
    {
        Task<SolicitudSuministroResponseDto> SolicitarSumministro(SolicitudSuministroDto solicitudSuministro);
    }
}
