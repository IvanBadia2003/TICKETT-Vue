using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tickett.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Obras",
                columns: table => new
                {
                    ObraId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaObra = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoraObra = table.Column<TimeSpan>(type: "time", nullable: false),
                    Imagen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duracion = table.Column<int>(type: "int", nullable: false),
                    Precio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Obras", x => x.ObraId);
                });

            migrationBuilder.CreateTable(
                name: "Repartos",
                columns: table => new
                {
                    RepartoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rol = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repartos", x => x.RepartoId);
                });

            migrationBuilder.CreateTable(
                name: "Butaca",
                columns: table => new
                {
                    ButacaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libre = table.Column<bool>(type: "bit", nullable: false),
                    ObraId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Butaca", x => x.ButacaId);
                    table.ForeignKey(
                        name: "FK_Butaca_Obras_ObraId",
                        column: x => x.ObraId,
                        principalTable: "Obras",
                        principalColumn: "ObraId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ObraRepartos",
                columns: table => new
                {
                    ObraId = table.Column<int>(type: "int", nullable: false),
                    RepartoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObraRepartos", x => new { x.ObraId, x.RepartoId });
                    table.ForeignKey(
                        name: "FK_ObraRepartos_Obras_ObraId",
                        column: x => x.ObraId,
                        principalTable: "Obras",
                        principalColumn: "ObraId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ObraRepartos_Repartos_RepartoId",
                        column: x => x.RepartoId,
                        principalTable: "Repartos",
                        principalColumn: "RepartoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Obras",
                columns: new[] { "ObraId", "Descripcion", "DiaObra", "Duracion", "Genero", "HoraObra", "Imagen", "Precio", "Titulo" },
                values: new object[,]
                {
                    { 1, "false", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 105, "Drama", new TimeSpan(0, 17, 0, 0, 0), "../IMAGENES/donjuan.jpg", 25, "Don Juan" },
                    { 2, "false", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 120, "Drama", new TimeSpan(0, 18, 30, 0, 0), "../IMAGENES/celestina.jpg", 15, "Celestina" },
                    { 3, "false", new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 115, "Drama", new TimeSpan(0, 16, 0, 0, 0), "../IMAGENES/doble-o-nada.jpg", 20, "Doble o nada" },
                    { 4, "false", new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 140, "Drama", new TimeSpan(0, 19, 15, 0, 0), "../IMAGENES/campeones.jpg", 35, "Campeones" },
                    { 5, "false", new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 135, "Drama", new TimeSpan(0, 18, 0, 0, 0), "../IMAGENES/el-mago-pop.jpg", 30, "El mago Pop" },
                    { 6, "false", new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 100, "Drama", new TimeSpan(0, 12, 0, 0, 0), "../IMAGENES/ElReyLeon3Aniv.jpg", 10, "El Rey Leon" },
                    { 7, "false", new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 90, "Drama", new TimeSpan(0, 20, 0, 0, 0), "../IMAGENES/fango.jpg", 40, "Fango" },
                    { 8, "false", new DateTime(2024, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 110, "Drama", new TimeSpan(0, 20, 30, 0, 0), "../IMAGENES/funcion-sale-mal.jpg", 30, "La Funcion que Sale Mal" },
                    { 9, "false", new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 120, "Drama", new TimeSpan(0, 15, 15, 0, 0), "../IMAGENES/ilusionate.jpg", 15, "Ilusionate" },
                    { 10, "false", new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 105, "Drama", new TimeSpan(0, 22, 15, 0, 0), "../IMAGENES/jose-el-sonador.jpg", 25, "Jose el sonñador" },
                    { 11, "false", new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 125, "Drama", new TimeSpan(0, 21, 30, 0, 0), "../IMAGENES/laponia.jpg", 20, "Laponia" },
                    { 12, "false", new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, "Drama", new TimeSpan(0, 19, 15, 0, 0), "../IMAGENES/las-mil-y-una-noches.jpg", 25, "Las mil y una noches" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Butaca_ObraId",
                table: "Butaca",
                column: "ObraId");

            migrationBuilder.CreateIndex(
                name: "IX_ObraRepartos_RepartoId",
                table: "ObraRepartos",
                column: "RepartoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Butaca");

            migrationBuilder.DropTable(
                name: "ObraRepartos");

            migrationBuilder.DropTable(
                name: "Obras");

            migrationBuilder.DropTable(
                name: "Repartos");
        }
    }
}
