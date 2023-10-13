using SuministroProvisiones.DOMAIN.Entities;

namespace SuministroProvisiones.Domain.IRepositories
{
    public interface ISolicitudSuministroResponseRepository
    {
        Task AddAsync(SolicitudSuministroResponse solicitud);
        int SaveChanges();
    }
}
