namespace SuministroProvisiones.Api.Models
{
    public class SolicitudSuministroDto
    {
        public int SolicitudSuministroId { get; set; }
        public double LongitudPuntoDestino { get; set; }
        public double LatitudPuntoDestino { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public string? TipoClima { get; set; }
        public int CantidadUnidades { get; set; }
    }
}
