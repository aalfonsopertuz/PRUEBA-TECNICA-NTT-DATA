using SuministroProvisiones.DOMAIN.Entities;

namespace SuministroProvisiones.Domain.IRepositories
{
    public interface ISolicitudSuministroRepository 
    {
        Task AddAsync(SolicitudSuministro solicitud);

        int SaveChanges();

    }
}
