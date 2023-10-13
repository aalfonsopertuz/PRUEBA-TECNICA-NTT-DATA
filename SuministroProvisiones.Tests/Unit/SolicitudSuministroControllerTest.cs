using Microsoft.AspNetCore.Mvc;
using Moq;
using SuministroProvisiones.Api.Controllers;
using SuministroProvisiones.Commons.Models;
using SuministroProvisiones.Domain.Services.IServices;


namespace SuministroProvisiones.Tests.Unit
{
    public class SolicitudSuministroControllerTest
    {
        [Fact]
        public async void Post_ValidModel_Returns200Status()
        {
            // Arrange
            var serviceMock = new Mock<ISolicitudSuministroService>();
            var controller = new SolicitudSuministroController(serviceMock.Object);
            var solicitud = new SolicitudSuministroDto
            {
                LongitudPuntoDestino = 1.0,
                LatitudPuntoDestino = 2.0,
                TipoClima = "Soleado",
                CantidadUnidades = 5
            };

            // Act
            var result = await controller.Post(solicitud);

            // Assert
            Assert.IsType<ActionResult<SolicitudSuministroResponseDto>>(result);
        }
    }
}
