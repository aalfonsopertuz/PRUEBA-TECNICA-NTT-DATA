using System.ComponentModel.DataAnnotations;

namespace SuministroProvisiones.DOMAIN.Entities
{
    public class SolicitudSuministro
    {
        [Key]
        public int SolicitudSuministroId { get; set; }
        public double LongitudPuntoDestino { get; set; }
        public double LatitudPuntoDestino { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public string? TipoClima { get; set; }
        public int CantidadUnidades { get; set; }

        public SolicitudSuministroResponse? SolicitudSuministroResponse { get; set; }

        public SolicitudSuministro()
        {
            this.Fecha = DateTime.Now;
            this.Hora = DateTime.Now.TimeOfDay;
        }
    }
}
