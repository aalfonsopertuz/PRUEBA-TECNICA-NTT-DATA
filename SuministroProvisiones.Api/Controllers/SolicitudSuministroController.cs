using Microsoft.AspNetCore.Mvc;
using SuministroProvisiones.Commons.Models;
using SuministroProvisiones.Domain.Services.IServices;

namespace SuministroProvisiones.Api.Controllers
{
    [Route("api/SolicitudSuministro")]
    [ApiController]
    public class SolicitudSuministroController : ControllerBase
    {
        private readonly ISolicitudSuministroService _service;

        public SolicitudSuministroController(ISolicitudSuministroService service)
        {
            _service = service;
        }


        [HttpPost]
        public async Task<ActionResult<SolicitudSuministroResponseDto>> Post([FromBody] SolicitudSuministroDto solicitud)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            { 
                SolicitudSuministroResponseDto reponse = await _service.SolicitarSumministro(solicitud);
                return StatusCode(200, reponse);
            }
            catch (Exception ex)
            {   
                return StatusCode(500, $"Ocurrió un error: {ex.InnerException}");
            }
        }
    }
}
