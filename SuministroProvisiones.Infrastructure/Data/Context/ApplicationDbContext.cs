using Microsoft.EntityFrameworkCore;
using SuministroProvisiones.DOMAIN.Entities;

namespace SuministroProvisiones.INFRAESTRUCTURE.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SolicitudSuministro>()
                .HasOne(ss => ss.SolicitudSuministroResponse)
                .WithOne(ssr => ssr.SolicitudSuministro)
                .HasForeignKey<SolicitudSuministroResponse>(ssr => ssr.SolicitudSuministroId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<SolicitudSuministro> SolicitudesSuministro { get; set; }
        public DbSet<SolicitudSuministroResponse> SolicitudesSuministroResponse { get; set; }
    }
}
