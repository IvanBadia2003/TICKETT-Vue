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
                name: "Sesion",
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
                    table.PrimaryKey("PK_Sesion", x => x.SesionId);
                    table.ForeignKey(
                        name: "FK_Sesion_Obras_ObraId",
                        column: x => x.ObraId,
                        principalTable: "Obras",
                        principalColumn: "ObraId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Butaca",
                columns: table => new
                {
                    ButacaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libre = table.Column<bool>(type: "bit", nullable: false),
                    SesionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Butaca", x => x.ButacaId);
                    table.ForeignKey(
                        name: "FK_Butaca_Sesion_SesionId",
                        column: x => x.SesionId,
                        principalTable: "Sesion",
                        principalColumn: "SesionId",
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
                    { 10, "false", new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 105, "Drama", new TimeSpan(0, 22, 15, 0, 0), "../IMAGENES/jose-el-sonador.jpg", 25, "Jose el soñador" },
                    { 11, "false", new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 125, "Drama", new TimeSpan(0, 21, 30, 0, 0), "../IMAGENES/laponia.jpg", 20, "Laponia" },
                    { 12, "false", new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, "Drama", new TimeSpan(0, 19, 15, 0, 0), "../IMAGENES/las-mil-y-una-noches.jpg", 25, "Las mil y una noches" }
                });

            migrationBuilder.InsertData(
                table: "Repartos",
                columns: new[] { "RepartoId", "Nombre", "Rol" },
                values: new object[,]
                {
                    { 1, "Luisa Fernández", "Doña Ana" },
                    { 2, "Andrés Sánchez", "Don Juan" },
                    { 3, "María Gómez", "Doña Inés" },
                    { 4, "Javier Rodríguez", "Don Luis" },
                    { 5, "Elena Pérez", "Doña Elvira" },
                    { 6, "Carlos Martínez", "Molière" },
                    { 7, "Ana Ruiz", "Sganarelle" },
                    { 8, "Pedro Vázquez", "Don Gonzalo" },
                    { 9, "Sofía Martínez", "Celestina" },
                    { 10, "Diego López", "Calisto" },
                    { 11, "Lucía García", "Melibea" },
                    { 12, "Javier Rodríguez", "Sempronio" },
                    { 13, "Elena Pérez", "Elicia" },
                    { 14, "Carlos Gómez", "Tristán" },
                    { 15, "Ana Ruiz", "Pármeno" },
                    { 16, "Pedro Vázquez", "Alisa" },
                    { 17, "Luis García", "Chris" },
                    { 18, "María López", "Annie" },
                    { 19, "Andrés Martínez", "Jonathan" },
                    { 20, "Elena Rodríguez", "Sandra" },
                    { 21, "Carlos Ruiz", "Max" },
                    { 22, "Lucía González", "Dennis" },
                    { 23, "Javier Fernández", "Trevor" },
                    { 24, "Ana Pérez", "Robert" },
                    { 25, "Erik Larsson", "Olaf, guía sami" },
                    { 26, "Ingrid Johansson", "Kaisa, chamán sami" },
                    { 27, "Sven Andersson", "Bjorn, explorador" },
                    { 28, "Hanna Bergman", "Lena, viajera aventurera" },
                    { 29, "Frida Nilsson", "Elsa, niña sami" },
                    { 30, "Oskar Magnusson", "Gunnar, habitante local" }
                });

            migrationBuilder.InsertData(
                table: "Repartos",
                columns: new[] { "RepartoId", "Nombre", "Rol" },
                values: new object[,]
                {
                    { 31, "Emma Karlsson", "Sofia, fotógrafa" },
                    { 32, "Viktor Lindström", "Ole, cazador" },
                    { 33, "Ana García", "José" },
                    { 34, "Luis Martínez", "Jacob" },
                    { 35, "María Fernández", "Rebeca" },
                    { 36, "Javier Rodríguez", "Faraón" },
                    { 37, "Elena Pérez", "Esposa de Potifar" },
                    { 38, "Carlos Sánchez", "Potifar" },
                    { 39, "Lucía Martín", "Mayordomo" },
                    { 40, "Andrés Gómez", "Elvisar" },
                    { 41, "Javier Martínez", "El Mago Pop (Antonio Díaz)" },
                    { 42, "Lucía García", "Asistente del Mago" },
                    { 43, "Andrés Fernández", "Participante del Público" },
                    { 44, "María López", "Asistente Técnico" },
                    { 45, "Carlos Ruiz", "Encargado de Escenario" },
                    { 46, "Elena Sánchez", "Coordinador de Efectos Especiales" },
                    { 47, "Pedro González", "Diseñador de Iluminación" },
                    { 48, "Ana Martín", "Gerente de Producción" },
                    { 49, "Sofía Martínez", "Lena, la ilusionista" },
                    { 50, "Diego López", "David, el aprendiz de mago" },
                    { 51, "Lucía García", "María, la asistente" },
                    { 52, "Javier Rodríguez", "Carlos, el escéptico" },
                    { 53, "Elena Pérez", "Laura, la espectadora" },
                    { 54, "Carlos Gómez", "Jorge, el incrédulo" },
                    { 55, "Ana Ruiz", "Paula, la admiradora" },
                    { 56, "Pedro Vázquez", "Pablo, el curioso" },
                    { 57, "Leyla Khan", "Scheherezade" },
                    { 58, "Amir Shah", "Sultán Shahriar" },
                    { 59, "Jamil Ahmed", "Aladino" },
                    { 60, "Nadia Malik", "Jasmine" },
                    { 61, "Karim Hassan", "Simbad" },
                    { 62, "Ayesha Khan", "Scheherezade (joven)" },
                    { 63, "Rashid Ali", "Ali Baba" },
                    { 64, "Yasir Mahmood", "Genio" },
                    { 65, "Sofía Martínez", "Nala" },
                    { 66, "Diego López", "Simba" },
                    { 67, "Lucía García", "Sarabi" },
                    { 68, "Javier Rodríguez", "Mufasa" },
                    { 69, "Elena Pérez", "Rafiki" },
                    { 70, "Carlos Gómez", "Scar" },
                    { 71, "Ana Ruiz", "Timón" },
                    { 72, "Pedro Vázquez", "Pumbaa" }
                });

            migrationBuilder.InsertData(
                table: "Repartos",
                columns: new[] { "RepartoId", "Nombre", "Rol" },
                values: new object[,]
                {
                    { 73, "María García", "Lola" },
                    { 74, "Javier Martínez", "Pedro" },
                    { 75, "Lucía Rodríguez", "Ana" },
                    { 76, "Andrés López", "Juan" },
                    { 77, "Elena Pérez", "Laura" },
                    { 78, "Carlos Gómez", "Pablo" },
                    { 79, "Ana Ruiz", "Carmen" },
                    { 80, "Pedro Vázquez", "Luis" },
                    { 81, "Sara Pérez", "Laura" },
                    { 82, "Javier García", "Carlos" },
                    { 83, "Lucía Martínez", "Ana" },
                    { 84, "Andrés López", "Diego" },
                    { 85, "Elena Rodríguez", "María" },
                    { 86, "Carlos Fernández", "Javier" },
                    { 87, "María Gómez", "Sofía" },
                    { 88, "Pedro Ruiz", "Pablo" },
                    { 89, "Laura Martínez", "Marina" },
                    { 90, "Diego López", "Carlos" },
                    { 91, "Ana Fernández", "Sandra" },
                    { 92, "Javier Gómez", "Mario" },
                    { 93, "Sofía Rodríguez", "Laura" },
                    { 94, "Andrés Pérez", "Pedro" },
                    { 95, "Elena Ruiz", "Lorena" },
                    { 96, "Carlos Martín", "Pablo" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Butaca_SesionId",
                table: "Butaca",
                column: "SesionId");

            migrationBuilder.CreateIndex(
                name: "IX_Sesion_ObraId",
                table: "Sesion",
                column: "ObraId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Butaca");

            migrationBuilder.DropTable(
                name: "Repartos");

            migrationBuilder.DropTable(
                name: "Sesion");

            migrationBuilder.DropTable(
                name: "Obras");
        }
    }
}
