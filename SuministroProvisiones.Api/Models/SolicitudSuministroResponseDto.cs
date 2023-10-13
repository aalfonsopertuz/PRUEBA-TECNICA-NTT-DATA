namespace SuministroProvisiones.Api.Models
{
    public class SolicitudSuministroResponseDto
    {
        public int SolicitudSuministroResponseId { get; set; }
        public double LongitudPuntoOrigen { get; set; }
        public double LatitudPuntoOrigen { get; set; }
        public DateTime FechaEntrega { get; set; }
        public TimeSpan HoraEntrega { get; set; }
        public TimeSpan TiempoEstimadoEntrega { get; set; }
        public int CantidadProvisionesEntregar { get; set; }
    }
}
