using SuministroProvisiones.Domain.IRepositories;
using SuministroProvisiones.DOMAIN.Entities;
using SuministroProvisiones.Infrastructure.Data.Context.IContext;

namespace SuministroProvisiones.Infrastructure.Data.Repositories
{
    public class SolicitudSuministroResponseRepository : ISolicitudSuministroResponseRepository
    {
        private readonly IApplicationDbContext _dbContext;

        public SolicitudSuministroResponseRepository(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> AddAsync(SolicitudSuministroResponse solicitud)
        {
            var entityEntry = await _dbContext.SolicitudesSuministroResponse.AddAsync(solicitud);
            return entityEntry.Entity.SolicitudSuministroResponseId;
        }
    }
}
