using SuministroProvisiones.Domain.IRepositories;
using SuministroProvisiones.DOMAIN.Entities;
using SuministroProvisiones.INFRAESTRUCTURE.Data.Context;

namespace SuministroProvisiones.Infrastructure.Data.Repositories
{
    public class SolicitudSuministroResponseRepository : ISolicitudSuministroResponseRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public SolicitudSuministroResponseRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(SolicitudSuministroResponse solicitud)
        {
            await _dbContext.SolicitudesSuministroResponse.AddAsync(solicitud);
        }

        public int SaveChanges()
        {
            return _dbContext.SaveChanges();
        }
    }
}
