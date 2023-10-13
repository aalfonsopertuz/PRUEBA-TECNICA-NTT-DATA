using System.ComponentModel.DataAnnotations;

namespace SuministroProvisiones.Commons.Models
{
    public class SolicitudSuministroDto
    {
        [Required(ErrorMessage = "La longitud del punto de destino es obligatoria.")]
        public double LongitudPuntoDestino { get; set; }

        [Required(ErrorMessage = "La latitud del punto de destino es obligatoria.")]
        public double LatitudPuntoDestino { get; set; }

        [RegularExpression("^(|Lluvioso|Soleado)$", ErrorMessage = "El tipo de clima solo puede ser '', 'Lluvioso' o 'Soleado'.")]
        public string? TipoClima { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "La cantidad de unidades no puede ser negativa.")]
        public int CantidadUnidades { get; set; }
    }
}
