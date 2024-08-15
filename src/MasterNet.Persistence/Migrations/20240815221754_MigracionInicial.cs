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
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    NombreCompleto = table.Column<string>(type: "TEXT", nullable: true),
                    Carrera = table.Column<string>(type: "TEXT", nullable: true),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0cab0dfa-71b8-4b9b-a88c-98fe2a400072", null, "CLIENTE", "CLIENTE" },
                    { "920a5681-1a15-4d07-a328-099ae525f036", null, "ADMIN", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "cursos",
                columns: new[] { "Id", "Descripcion", "FechaPublicacion", "Titulo" },
                values: new object[,]
                {
                    { new Guid("03acd1dc-62ce-4a2d-8d35-178ff9aa3b06"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new DateTime(2024, 8, 15, 22, 17, 54, 166, DateTimeKind.Utc).AddTicks(1442), "Generic Cotton Gloves" },
                    { new Guid("3c6d24a5-0bd2-4393-a16e-d5478b47d415"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new DateTime(2024, 8, 15, 22, 17, 54, 166, DateTimeKind.Utc).AddTicks(1550), "Rustic Cotton Bike" },
                    { new Guid("5aacba3b-05e5-4cf2-84d7-054568040934"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new DateTime(2024, 8, 15, 22, 17, 54, 166, DateTimeKind.Utc).AddTicks(1303), "Ergonomic Frozen Shoes" },
                    { new Guid("735fa748-cbd8-463d-9738-ac47c233f071"), "The Football Is Good For Training And Recreational Purposes", new DateTime(2024, 8, 15, 22, 17, 54, 166, DateTimeKind.Utc).AddTicks(1482), "Generic Rubber Computer" },
                    { new Guid("992af6a3-b8a0-43c6-8743-a8efc2c4ace9"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new DateTime(2024, 8, 15, 22, 17, 54, 166, DateTimeKind.Utc).AddTicks(1462), "Handcrafted Wooden Chicken" },
                    { new Guid("9b47dd9d-9088-495c-92ea-e91652ef461b"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new DateTime(2024, 8, 15, 22, 17, 54, 166, DateTimeKind.Utc).AddTicks(1502), "Small Granite Chips" },
                    { new Guid("ad4de404-9187-4959-a2e4-358362bc4ce4"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new DateTime(2024, 8, 15, 22, 17, 54, 166, DateTimeKind.Utc).AddTicks(1417), "Small Concrete Ball" },
                    { new Guid("da613ac0-8665-47a0-b932-60c91727c06f"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new DateTime(2024, 8, 15, 22, 17, 54, 166, DateTimeKind.Utc).AddTicks(1569), "Incredible Soft Computer" },
                    { new Guid("e5c9edea-fcb3-495e-9ab7-bbd41236bee8"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new DateTime(2024, 8, 15, 22, 17, 54, 166, DateTimeKind.Utc).AddTicks(1532), "Practical Rubber Soap" }
                });

            migrationBuilder.InsertData(
                table: "instructores",
                columns: new[] { "Id", "Apeliidos", "Grado", "Nombre" },
                values: new object[,]
                {
                    { new Guid("264b7b09-73fb-4686-8fd8-822a3ac2ecc9"), "Waelchi", "Forward Tactics Orchestrator", "Cristobal Cronin" },
                    { new Guid("584dcc85-a5b9-48ea-9a7e-2dc689353b6e"), "Brekke", "Future Security Director", "Estefania Lueilwitz" },
                    { new Guid("6dce1e48-c971-4bef-a6cc-2fff55ff24d8"), "Waters", "Future Directives Administrator", "Aglae Schoen" },
                    { new Guid("8257497b-6604-4889-b21b-b288a542850d"), "Rau", "Corporate Marketing Producer", "Zella Hahn" },
                    { new Guid("9109ece1-3d35-4bd9-acd6-663220e10411"), "Borer", "National Mobility Architect", "Ezra Bayer" },
                    { new Guid("9476d091-e8b4-41d6-bd5f-fb09a9eee9f0"), "Predovic", "Product Accountability Planner", "Janet Jones" },
                    { new Guid("a00a2750-128c-4489-89a0-131684d546f0"), "Davis", "Direct Marketing Orchestrator", "Ezra Corkery" },
                    { new Guid("b0ade233-b523-4f44-9642-aba8308e1f89"), "Wehner", "Central Identity Technician", "Norris Kling" },
                    { new Guid("e00c1057-4869-42bb-9692-c9865f955df1"), "Carroll", "Global Communications Specialist", "Elta Kshlerin" },
                    { new Guid("e07144d3-b024-4ace-a403-62e604397511"), "Zieme", "Global Branding Orchestrator", "Maymie Pfeffer" }
                });

            migrationBuilder.InsertData(
                table: "precios",
                columns: new[] { "Id", "Nombre", "PrecioActual", "PrecioPromocion" },
                values: new object[] { new Guid("74b5309c-a0f6-4a9b-87af-6bb66aca389f"), "Precio regular", 10.0m, 8.0m });

            migrationBuilder.InsertData(
                table: "AspNetRoleClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "RoleId" },
                values: new object[,]
                {
                    { 1, "POLICIES", "CURSO_READ", "920a5681-1a15-4d07-a328-099ae525f036" },
                    { 2, "POLICIES", "CURSO_UPDATE", "920a5681-1a15-4d07-a328-099ae525f036" },
                    { 3, "POLICIES", "CURSO_WRITE", "920a5681-1a15-4d07-a328-099ae525f036" },
                    { 4, "POLICIES", "CURSO_DELETE", "920a5681-1a15-4d07-a328-099ae525f036" },
                    { 5, "POLICIES", "INSTRUCTOR_CREATE", "920a5681-1a15-4d07-a328-099ae525f036" },
                    { 6, "POLICIES", "INSTRUCTOR_READ", "920a5681-1a15-4d07-a328-099ae525f036" },
                    { 7, "POLICIES", "INSTRUCTOR_UPDATE", "920a5681-1a15-4d07-a328-099ae525f036" },
                    { 8, "POLICIES", "COMENTARIO_READ", "920a5681-1a15-4d07-a328-099ae525f036" },
                    { 9, "POLICIES", "COMENTARIO_DELETE", "920a5681-1a15-4d07-a328-099ae525f036" },
                    { 10, "POLICIES", "COMENTARIO_CREATE", "920a5681-1a15-4d07-a328-099ae525f036" },
                    { 11, "POLICIES", "CURSO_READ", "0cab0dfa-71b8-4b9b-a88c-98fe2a400072" },
                    { 12, "POLICIES", "INSTRUCTOR_READ", "0cab0dfa-71b8-4b9b-a88c-98fe2a400072" },
                    { 13, "POLICIES", "COMENTARIO_READ", "0cab0dfa-71b8-4b9b-a88c-98fe2a400072" },
                    { 14, "POLICIES", "COMENTARIO_CREATE", "0cab0dfa-71b8-4b9b-a88c-98fe2a400072" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

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
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "calificaciones");

            migrationBuilder.DropTable(
                name: "cursos_instructores");

            migrationBuilder.DropTable(
                name: "cursos_precios");

            migrationBuilder.DropTable(
                name: "imagenes");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "instructores");

            migrationBuilder.DropTable(
                name: "precios");

            migrationBuilder.DropTable(
                name: "cursos");
        }
    }
}
