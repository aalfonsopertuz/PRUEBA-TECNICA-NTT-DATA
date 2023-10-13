using Microsoft.EntityFrameworkCore;
using SuministroProvisiones.DOMAIN.Entities;
using SuministroProvisiones.Infrastructure.Data.Context.IContext;

namespace SuministroProvisiones.INFRAESTRUCTURE.Data.Context
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SolicitudSuministro>()
                .HasOne(ss => ss.SolicitudSuministroResponse)
                .WithOne(ssr => ssr.SolicitudSuministro)
                .HasForeignKey<SolicitudSuministroResponse>(ssr => ssr.SolicitudSuministroResponseId);

            base.OnModelCreating(modelBuilder);
        }

        DbSet<SolicitudSuministro> IApplicationDbContext.SolicitudesSuministro { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        DbSet<SolicitudSuministroResponse> IApplicationDbContext.SolicitudesSuministroResponse { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
