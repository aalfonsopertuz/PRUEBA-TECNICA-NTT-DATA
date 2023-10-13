using Microsoft.EntityFrameworkCore;
using SuministroProvisiones.Domain.IRepositories;
using SuministroProvisiones.DOMAIN.Entities;
using SuministroProvisiones.INFRAESTRUCTURE.Data.Context;

namespace SuministroProvisiones.Infrastructure.Data.Repositories
{
    public class SolicitudSuministroRepository : ISolicitudSuministroRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public SolicitudSuministroRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(SolicitudSuministro solicitud)
        {
            await _dbContext.SolicitudesSuministro.AddAsync(solicitud);
        }

        public int SaveChanges() 
        {
            return _dbContext.SaveChanges();
        }

    }
}
