using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taller_EquiposFutbol2.Migrations
{
    /// <inheritdoc />
    public partial class PrimeraMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estadio",
                columns: table => new
                {
                    IdEstadio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEstadio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Capacidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estadio", x => x.IdEstadio);
                });

            migrationBuilder.CreateTable(
                name: "Equipo",
                columns: table => new
                {
                    IdEquipo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEquipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitulosEquipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdmiteExtranjeros = table.Column<bool>(type: "bit", nullable: false),
                    IdEstadio = table.Column<int>(type: "int", nullable: false),
                    EstadioIdEstadio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipo", x => x.IdEquipo);
                    table.ForeignKey(
                        name: "FK_Equipo_Estadio_EstadioIdEstadio",
                        column: x => x.EstadioIdEstadio,
                        principalTable: "Estadio",
                        principalColumn: "IdEstadio",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Jugador",
                columns: table => new
                {
                    IdJugador = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreJugador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Posicion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    IdEquipo = table.Column<int>(type: "int", nullable: false),
                    EquipoIdEquipo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jugador", x => x.IdJugador);
                    table.ForeignKey(
                        name: "FK_Jugador_Equipo_EquipoIdEquipo",
                        column: x => x.EquipoIdEquipo,
                        principalTable: "Equipo",
                        principalColumn: "IdEquipo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Equipo_EstadioIdEstadio",
                table: "Equipo",
                column: "EstadioIdEstadio");

            migrationBuilder.CreateIndex(
                name: "IX_Jugador_EquipoIdEquipo",
                table: "Jugador",
                column: "EquipoIdEquipo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jugador");

            migrationBuilder.DropTable(
                name: "Equipo");

            migrationBuilder.DropTable(
                name: "Estadio");
        }
    }
}
