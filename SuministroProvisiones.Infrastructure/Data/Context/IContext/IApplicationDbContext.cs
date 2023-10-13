using Microsoft.EntityFrameworkCore;
using SuministroProvisiones.DOMAIN.Entities;

namespace SuministroProvisiones.Infrastructure.Data.Context.IContext
{
    public interface IApplicationDbContext
    {
        DbSet<SolicitudSuministro> SolicitudesSuministro { get; set; }
        DbSet<SolicitudSuministroResponse> SolicitudesSuministroResponse { get; set; }
    }
}
