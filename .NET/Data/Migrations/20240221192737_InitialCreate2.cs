using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tickett.Data.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "ObraRepartos",
                columns: new[] { "ObraId", "RepartoId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 7 },
                    { 1, 8 },
                    { 2, 9 },
                    { 2, 10 },
                    { 2, 11 },
                    { 2, 12 },
                    { 2, 13 },
                    { 2, 14 },
                    { 2, 15 },
                    { 2, 16 },
                    { 3, 17 },
                    { 3, 18 },
                    { 3, 19 },
                    { 3, 20 },
                    { 3, 21 },
                    { 3, 22 },
                    { 3, 23 },
                    { 3, 24 },
                    { 4, 25 },
                    { 4, 26 },
                    { 4, 27 },
                    { 4, 28 },
                    { 4, 29 },
                    { 4, 30 },
                    { 4, 31 },
                    { 4, 32 },
                    { 5, 33 },
                    { 5, 34 },
                    { 5, 35 },
                    { 5, 36 },
                    { 5, 37 },
                    { 5, 38 },
                    { 5, 39 },
                    { 5, 40 },
                    { 6, 41 },
                    { 6, 42 }
                });

            migrationBuilder.InsertData(
                table: "ObraRepartos",
                columns: new[] { "ObraId", "RepartoId" },
                values: new object[,]
                {
                    { 6, 43 },
                    { 6, 44 },
                    { 6, 45 },
                    { 6, 46 },
                    { 6, 47 },
                    { 6, 48 },
                    { 7, 49 },
                    { 7, 50 },
                    { 7, 51 },
                    { 7, 52 },
                    { 7, 53 },
                    { 7, 54 },
                    { 7, 55 },
                    { 7, 56 },
                    { 8, 57 },
                    { 8, 58 },
                    { 8, 59 },
                    { 8, 60 },
                    { 8, 61 },
                    { 8, 62 },
                    { 8, 63 },
                    { 8, 64 },
                    { 9, 65 },
                    { 9, 66 },
                    { 9, 67 },
                    { 9, 68 },
                    { 9, 69 },
                    { 9, 70 },
                    { 9, 71 },
                    { 9, 72 },
                    { 10, 73 },
                    { 10, 74 },
                    { 10, 75 },
                    { 10, 76 },
                    { 10, 77 },
                    { 10, 78 },
                    { 10, 79 },
                    { 10, 80 },
                    { 11, 81 },
                    { 11, 82 },
                    { 11, 83 },
                    { 11, 84 }
                });

            migrationBuilder.InsertData(
                table: "ObraRepartos",
                columns: new[] { "ObraId", "RepartoId" },
                values: new object[,]
                {
                    { 11, 85 },
                    { 11, 86 },
                    { 11, 87 },
                    { 11, 88 },
                    { 12, 89 },
                    { 12, 90 },
                    { 12, 91 },
                    { 12, 92 },
                    { 12, 93 },
                    { 12, 94 },
                    { 12, 95 },
                    { 12, 96 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ObraRepartos_RepartoId",
                table: "ObraRepartos",
                column: "RepartoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ObraRepartos");
        }
    }
}
