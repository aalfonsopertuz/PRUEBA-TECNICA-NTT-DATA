using SuministroProvisiones.DOMAIN.Entities;

namespace SuministroProvisiones.Domain.IRepositories
{
    public interface ISolicitudSuministroResponseRepository
    {
        Task<int> AddAsync(SolicitudSuministroResponse solicitud);
    }
}
