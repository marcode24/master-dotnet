using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MasterNet.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class MigracionInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cursos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Titulo = table.Column<string>(type: "TEXT", nullable: true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    FechaPublicacion = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cursos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "instructores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Apeliidos = table.Column<string>(type: "TEXT", nullable: true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    Grado = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_instructores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "precios",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Nombre = table.Column<string>(type: "VARCHAR", maxLength: 250, nullable: true),
                    PrecioActual = table.Column<decimal>(type: "TEXT", precision: 10, scale: 2, nullable: false),
                    PrecioPromocion = table.Column<decimal>(type: "TEXT", precision: 10, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_precios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "calificaciones",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Alumno = table.Column<string>(type: "TEXT", nullable: true),
                    Puntaje = table.Column<int>(type: "INTEGER", nullable: false),
                    Comentario = table.Column<string>(type: "TEXT", nullable: true),
                    CursoId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_calificaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_calificaciones_cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "imagenes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: true),
                    CursoId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_imagenes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_imagenes_cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cursos_instructores",
                columns: table => new
                {
                    CursoId = table.Column<Guid>(type: "TEXT", nullable: false),
                    InstructorId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cursos_instructores", x => new { x.CursoId, x.InstructorId });
                    table.ForeignKey(
                        name: "FK_cursos_instructores_cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cursos_instructores_instructores_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "instructores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cursos_precios",
                columns: table => new
                {
                    CursoId = table.Column<Guid>(type: "TEXT", nullable: false),
                    PrecioId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cursos_precios", x => new { x.CursoId, x.PrecioId });
                    table.ForeignKey(
                        name: "FK_cursos_precios_cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cursos_precios_precios_PrecioId",
                        column: x => x.PrecioId,
                        principalTable: "precios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "cursos",
                columns: new[] { "Id", "Descripcion", "FechaPublicacion", "Titulo" },
                values: new object[,]
                {
                    { new Guid("43827640-1fa0-462b-ac6a-f5bdb506ea4b"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new DateTime(2024, 8, 15, 5, 3, 46, 776, DateTimeKind.Utc).AddTicks(2505), "Awesome Granite Ball" },
                    { new Guid("887583e3-0234-4287-8f3c-aabf8a8d0bfa"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new DateTime(2024, 8, 15, 5, 3, 46, 776, DateTimeKind.Utc).AddTicks(2701), "Practical Fresh Bike" },
                    { new Guid("93c60a5c-a6d2-4af5-a0a4-c8e364445734"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new DateTime(2024, 8, 15, 5, 3, 46, 776, DateTimeKind.Utc).AddTicks(2728), "Tasty Soft Fish" },
                    { new Guid("9eaf2472-d798-418b-b118-c4153f2e2c85"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new DateTime(2024, 8, 15, 5, 3, 46, 776, DateTimeKind.Utc).AddTicks(2716), "Awesome Concrete Pants" },
                    { new Guid("b51c35db-d7c9-4455-af95-b91f9c455f82"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new DateTime(2024, 8, 15, 5, 3, 46, 776, DateTimeKind.Utc).AddTicks(2479), "Gorgeous Cotton Hat" },
                    { new Guid("b612ccc6-3c42-4709-8048-d0ac796ca733"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new DateTime(2024, 8, 15, 5, 3, 46, 776, DateTimeKind.Utc).AddTicks(2533), "Ergonomic Cotton Hat" },
                    { new Guid("de1f1d8f-9554-443b-add3-3ebd9739a3a2"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new DateTime(2024, 8, 15, 5, 3, 46, 776, DateTimeKind.Utc).AddTicks(2521), "Incredible Plastic Shoes" },
                    { new Guid("e3e371a9-b5f5-45bb-b0cf-c22c96c75a57"), "The Football Is Good For Training And Recreational Purposes", new DateTime(2024, 8, 15, 5, 3, 46, 776, DateTimeKind.Utc).AddTicks(2566), "Tasty Soft Table" },
                    { new Guid("fb195683-889b-4530-8486-8f72b13c2e9a"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new DateTime(2024, 8, 15, 5, 3, 46, 776, DateTimeKind.Utc).AddTicks(2544), "Awesome Wooden Hat" }
                });

            migrationBuilder.InsertData(
                table: "instructores",
                columns: new[] { "Id", "Apeliidos", "Grado", "Nombre" },
                values: new object[,]
                {
                    { new Guid("2dd7269f-9c58-41e6-9869-2e97f873b482"), "White", "Corporate Infrastructure Planner", "Rosalinda Bauch" },
                    { new Guid("46b312d0-c872-42e8-ae99-9d2b818cc2b3"), "Dare", "National Marketing Facilitator", "Mable Robel" },
                    { new Guid("54cf8971-6b4d-4a3e-840c-84fea29843d2"), "Lebsack", "International Interactions Facilitator", "Haylie Ebert" },
                    { new Guid("87b664f4-c2b4-4c11-ba13-722623720e8e"), "Orn", "Human Intranet Representative", "Clark Schoen" },
                    { new Guid("9a8fd4df-6341-4f2e-bc03-48ca5b1b957c"), "Botsford", "Future Applications Director", "Serenity Lesch" },
                    { new Guid("bc5d9efe-89ef-4471-ab0a-304b248896c3"), "Schneider", "Dynamic Functionality Director", "Gretchen Denesik" },
                    { new Guid("d5772c7b-533d-48dd-b70d-c14bb1593407"), "Braun", "Legacy Research Analyst", "Lillie Ebert" },
                    { new Guid("db40ef63-e935-4a82-8c86-4677d1548015"), "Halvorson", "Dynamic Intranet Director", "Cecilia Kreiger" },
                    { new Guid("e1977c9d-aea4-4f3b-a239-f3a4737ced13"), "Jaskolski", "Corporate Interactions Manager", "Mittie Wehner" },
                    { new Guid("e2d5390a-d015-48e5-bed1-26f0f7448a4f"), "Lakin", "Central Identity Orchestrator", "Victor Gorczany" }
                });

            migrationBuilder.InsertData(
                table: "precios",
                columns: new[] { "Id", "Nombre", "PrecioActual", "PrecioPromocion" },
                values: new object[] { new Guid("aa8d523a-bdaf-43a0-99e9-73ea0ce35b93"), "Precio regular", 10.0m, 8.0m });

            migrationBuilder.CreateIndex(
                name: "IX_calificaciones_CursoId",
                table: "calificaciones",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_cursos_instructores_InstructorId",
                table: "cursos_instructores",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_cursos_precios_PrecioId",
                table: "cursos_precios",
                column: "PrecioId");

            migrationBuilder.CreateIndex(
                name: "IX_imagenes_CursoId",
                table: "imagenes",
                column: "CursoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "calificaciones");

            migrationBuilder.DropTable(
                name: "cursos_instructores");

            migrationBuilder.DropTable(
                name: "cursos_precios");

            migrationBuilder.DropTable(
                name: "imagenes");

            migrationBuilder.DropTable(
                name: "instructores");

            migrationBuilder.DropTable(
                name: "precios");

            migrationBuilder.DropTable(
                name: "cursos");
        }
    }
}
