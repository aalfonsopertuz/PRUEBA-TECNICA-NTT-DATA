using SuministroProvisiones.DOMAIN.Entities;

namespace SuministroProvisiones.Domain.IRepositories
{
    public interface ISolicitudSuministroRepository
    {
        Task<int> AddAsync(SolicitudSuministro solicitud);

    }
}
