using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tickett.Data.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Butacas_Sesiones_SesionId",
                table: "Butacas");

            migrationBuilder.DropTable(
                name: "Sesiones");

            migrationBuilder.DropIndex(
                name: "IX_Butacas_SesionId",
                table: "Butacas");

            migrationBuilder.DropColumn(
                name: "SesionId",
                table: "Butacas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SesionId",
                table: "Butacas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Sesiones",
                columns: table => new
                {
                    SesionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ObraId = table.Column<int>(type: "int", nullable: false),
                    DiaObra = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoraObra = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sesiones", x => x.SesionId);
                    table.ForeignKey(
                        name: "FK_Sesiones_Obras_ObraId",
                        column: x => x.ObraId,
                        principalTable: "Obras",
                        principalColumn: "ObraId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Sesiones",
                columns: new[] { "SesionId", "DiaObra", "HoraObra", "ObraId" },
                values: new object[] { 1, new DateTime(2024, 1, 13, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Butacas_SesionId",
                table: "Butacas",
                column: "SesionId");

            migrationBuilder.CreateIndex(
                name: "IX_Sesiones_ObraId",
                table: "Sesiones",
                column: "ObraId");

            migrationBuilder.AddForeignKey(
                name: "FK_Butacas_Sesiones_SesionId",
                table: "Butacas",
                column: "SesionId",
                principalTable: "Sesiones",
                principalColumn: "SesionId");
        }
    }
}
