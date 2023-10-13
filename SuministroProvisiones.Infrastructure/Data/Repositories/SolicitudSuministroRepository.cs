using SuministroProvisiones.Domain.IRepositories;
using SuministroProvisiones.DOMAIN.Entities;
using SuministroProvisiones.Infrastructure.Data.Context.IContext;

namespace SuministroProvisiones.Infrastructure.Data.Repositories
{
    public class SolicitudSuministroRepository : ISolicitudSuministroRepository
    {
        private readonly IApplicationDbContext _dbContext;

        public SolicitudSuministroRepository(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> AddAsync(SolicitudSuministro solicitud)
        {
            var entityEntry = await _dbContext.SolicitudesSuministro.AddAsync(solicitud);
            return entityEntry.Entity.SolicitudSuministroId;
        }
    }
}
