using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuministroProvisiones.Infrastructure.Data.Migrations
{
    public partial class Migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SolicitudesSuministro",
                columns: table => new
                {
                    SolicitudSuministroId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LongitudPuntoDestino = table.Column<double>(type: "float", nullable: false),
                    LatitudPuntoDestino = table.Column<double>(type: "float", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Hora = table.Column<TimeSpan>(type: "time", nullable: false),
                    TipoClima = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CantidadUnidades = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolicitudesSuministro", x => x.SolicitudSuministroId);
                });

            migrationBuilder.CreateTable(
                name: "SolicitudesSuministroResponse",
                columns: table => new
                {
                    SolicitudSuministroResponseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LongitudPuntoOrigen = table.Column<double>(type: "float", nullable: false),
                    LatitudPuntoOrigen = table.Column<double>(type: "float", nullable: false),
                    FechaEntrega = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoraEntrega = table.Column<TimeSpan>(type: "time", nullable: false),
                    TiempoEstimadoEntrega = table.Column<TimeSpan>(type: "time", nullable: false),
                    CantidadProvisionesEntregar = table.Column<int>(type: "int", nullable: false),
                    SolicitudSuministroId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolicitudesSuministroResponse", x => x.SolicitudSuministroResponseId);
                    table.ForeignKey(
                        name: "FK_SolicitudesSuministroResponse_SolicitudesSuministro_SolicitudSuministroId",
                        column: x => x.SolicitudSuministroId,
                        principalTable: "SolicitudesSuministro",
                        principalColumn: "SolicitudSuministroId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudesSuministroResponse_SolicitudSuministroId",
                table: "SolicitudesSuministroResponse",
                column: "SolicitudSuministroId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SolicitudesSuministroResponse");

            migrationBuilder.DropTable(
                name: "SolicitudesSuministro");
        }
    }
}
