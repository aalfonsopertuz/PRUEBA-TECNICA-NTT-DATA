using SuministroProvisiones.Commons.Helpers;
using System.ComponentModel.DataAnnotations;

namespace SuministroProvisiones.DOMAIN.Entities
{
    public class SolicitudSuministroResponse
    {
        [Key]
        public int SolicitudSuministroResponseId { get; set; }
        public double LongitudPuntoOrigen { get; set; }
        public double LatitudPuntoOrigen { get; set; }
        public DateTime FechaEntrega { get; set; }
        public TimeSpan HoraEntrega { get; set; }
        public TimeSpan TiempoEstimadoEntrega { get; set; }
        public int CantidadProvisionesEntregar { get; set; }

        public int SolicitudSuministroId { get; set; }
        public SolicitudSuministro? SolicitudSuministro { get; set; }


        public SolicitudSuministroResponse()
        {
                
        }

        public SolicitudSuministroResponse(SolicitudSuministro solicitud)
        {
            this.LongitudPuntoOrigen = -74.0060;
            this.LatitudPuntoOrigen = 40.7128;
            this.FechaEntrega = solicitud.Fecha;
            this.HoraEntrega = solicitud.Hora + new TimeSpan(1, 0, 0);
            this.CantidadProvisionesEntregar = SolicitudSuministroResponseHelper.GenerarCantidadProvisionesEntregar(solicitud.CantidadUnidades);
            this.TiempoEstimadoEntrega = SolicitudSuministroResponseHelper.ObtenerTiempo(solicitud.TipoClima ?? "", solicitud.Hora);
            this.SolicitudSuministroId = solicitud.SolicitudSuministroId;
            this.SolicitudSuministro = solicitud;
        }

    }

}
