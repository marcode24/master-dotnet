using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MasterNet.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class MigracionSeguridad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("43827640-1fa0-462b-ac6a-f5bdb506ea4b"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("887583e3-0234-4287-8f3c-aabf8a8d0bfa"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("93c60a5c-a6d2-4af5-a0a4-c8e364445734"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("9eaf2472-d798-418b-b118-c4153f2e2c85"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("b51c35db-d7c9-4455-af95-b91f9c455f82"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("b612ccc6-3c42-4709-8048-d0ac796ca733"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("de1f1d8f-9554-443b-add3-3ebd9739a3a2"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("e3e371a9-b5f5-45bb-b0cf-c22c96c75a57"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("fb195683-889b-4530-8486-8f72b13c2e9a"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("2dd7269f-9c58-41e6-9869-2e97f873b482"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("46b312d0-c872-42e8-ae99-9d2b818cc2b3"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("54cf8971-6b4d-4a3e-840c-84fea29843d2"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("87b664f4-c2b4-4c11-ba13-722623720e8e"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("9a8fd4df-6341-4f2e-bc03-48ca5b1b957c"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("bc5d9efe-89ef-4471-ab0a-304b248896c3"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("d5772c7b-533d-48dd-b70d-c14bb1593407"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("db40ef63-e935-4a82-8c86-4677d1548015"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("e1977c9d-aea4-4f3b-a239-f3a4737ced13"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("e2d5390a-d015-48e5-bed1-26f0f7448a4f"));

            migrationBuilder.DeleteData(
                table: "precios",
                keyColumn: "Id",
                keyValue: new Guid("aa8d523a-bdaf-43a0-99e9-73ea0ce35b93"));

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "72361dc2-1c3d-4046-9ed1-1057e9b26563", null, "ADMIN", "ADMIN" },
                    { "857e7343-1de0-4523-9144-32a004ad845b", null, "CLIENTE", "CLIENTE" }
                });

            migrationBuilder.InsertData(
                table: "cursos",
                columns: new[] { "Id", "Descripcion", "FechaPublicacion", "Titulo" },
                values: new object[,]
                {
                    { new Guid("0e296de3-1111-4bf7-8d39-f4457c69ec36"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new DateTime(2024, 8, 15, 5, 55, 0, 432, DateTimeKind.Utc).AddTicks(9697), "Incredible Concrete Hat" },
                    { new Guid("20a4c079-6f98-4dd1-8b0a-692f25e74614"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new DateTime(2024, 8, 15, 5, 55, 0, 432, DateTimeKind.Utc).AddTicks(9596), "Ergonomic Granite Chips" },
                    { new Guid("29a40630-651b-40f8-9329-06de3f7c0a88"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new DateTime(2024, 8, 15, 5, 55, 0, 432, DateTimeKind.Utc).AddTicks(9617), "Refined Granite Ball" },
                    { new Guid("4712eae9-db13-4fb9-afb9-d5f7e52c7fc2"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new DateTime(2024, 8, 15, 5, 55, 0, 432, DateTimeKind.Utc).AddTicks(9740), "Refined Plastic Fish" },
                    { new Guid("6ce019c9-48b8-4872-b323-e8a957970a1d"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new DateTime(2024, 8, 15, 5, 55, 0, 432, DateTimeKind.Utc).AddTicks(9641), "Sleek Steel Pants" },
                    { new Guid("a57db0b7-186a-4661-827b-dc7c8c9a4f46"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new DateTime(2024, 8, 15, 5, 55, 0, 432, DateTimeKind.Utc).AddTicks(9630), "Small Wooden Fish" },
                    { new Guid("b8344d18-2316-45fc-b64b-b4b805fc8ea8"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new DateTime(2024, 8, 15, 5, 55, 0, 432, DateTimeKind.Utc).AddTicks(9668), "Practical Rubber Towels" },
                    { new Guid("ba5569be-27e0-4f20-9761-b15eafcd962f"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new DateTime(2024, 8, 15, 5, 55, 0, 432, DateTimeKind.Utc).AddTicks(9751), "Ergonomic Cotton Table" },
                    { new Guid("f81e2341-0e27-463c-87e5-54fe5954de4a"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new DateTime(2024, 8, 15, 5, 55, 0, 432, DateTimeKind.Utc).AddTicks(9685), "Practical Plastic Cheese" }
                });

            migrationBuilder.InsertData(
                table: "instructores",
                columns: new[] { "Id", "Apeliidos", "Grado", "Nombre" },
                values: new object[,]
                {
                    { new Guid("0fb2e7b9-f852-4ab1-8c6b-d8edeced411a"), "Tromp", "Global Applications Executive", "Eve Vandervort" },
                    { new Guid("28e4c349-6123-4da6-ab2a-b662733a370b"), "Howe", "Future Branding Strategist", "Lester Lang" },
                    { new Guid("6378c4d4-16d2-460d-a3c3-6b9ba74e8007"), "Maggio", "Future Accountability Representative", "Kylee Pagac" },
                    { new Guid("82432ed5-a244-4fc3-bdaa-243da6b5fc3e"), "Hickle", "District Mobility Officer", "Hassan Heathcote" },
                    { new Guid("84f2de5f-cc20-4d6b-a31f-69c9952bc84b"), "Schuppe", "Regional Group Officer", "Anastasia Boehm" },
                    { new Guid("8f5d2428-397d-485a-b1fd-f2ab542d3df3"), "Abernathy", "National Brand Technician", "Johnny Abernathy" },
                    { new Guid("90e66d1d-cee3-427d-b7f6-d4a37a49c227"), "Steuber", "Lead Usability Assistant", "Moshe Schaefer" },
                    { new Guid("a924afb7-53d5-472f-aced-738c6645953e"), "McCullough", "Internal Mobility Engineer", "Elinor Jacobs" },
                    { new Guid("b7cb8809-24ac-4e9a-bfb3-af5255706b4b"), "Haley", "Investor Accountability Coordinator", "Rahul Lindgren" },
                    { new Guid("e2ec7094-28ca-48ae-a271-dc50123d742d"), "Brakus", "Investor Brand Developer", "Pascale Emmerich" }
                });

            migrationBuilder.InsertData(
                table: "precios",
                columns: new[] { "Id", "Nombre", "PrecioActual", "PrecioPromocion" },
                values: new object[] { new Guid("bf8fab3c-8b25-4401-bf5d-f823baac4abb"), "Precio regular", 10.0m, 8.0m });

            migrationBuilder.InsertData(
                table: "AspNetRoleClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "RoleId" },
                values: new object[,]
                {
                    { 1, "POLICIES", "CURSO_READ", "72361dc2-1c3d-4046-9ed1-1057e9b26563" },
                    { 2, "POLICIES", "CURSO_UPDATE", "72361dc2-1c3d-4046-9ed1-1057e9b26563" },
                    { 3, "POLICIES", "CURSO_WRITE", "72361dc2-1c3d-4046-9ed1-1057e9b26563" },
                    { 4, "POLICIES", "CURSO_DELETE", "72361dc2-1c3d-4046-9ed1-1057e9b26563" },
                    { 5, "POLICIES", "INSTRUCTOR_CREATE", "72361dc2-1c3d-4046-9ed1-1057e9b26563" },
                    { 6, "POLICIES", "INSTRUCTOR_READ", "72361dc2-1c3d-4046-9ed1-1057e9b26563" },
                    { 7, "POLICIES", "INSTRUCTOR_UPDATE", "72361dc2-1c3d-4046-9ed1-1057e9b26563" },
                    { 8, "POLICIES", "COMENTARIO_READ", "72361dc2-1c3d-4046-9ed1-1057e9b26563" },
                    { 9, "POLICIES", "COMENTARIO_DELETE", "72361dc2-1c3d-4046-9ed1-1057e9b26563" },
                    { 10, "POLICIES", "COMENTARIO_CREATE", "72361dc2-1c3d-4046-9ed1-1057e9b26563" },
                    { 11, "POLICIES", "CURSO_READ", "857e7343-1de0-4523-9144-32a004ad845b" },
                    { 12, "POLICIES", "INSTRUCTOR_READ", "857e7343-1de0-4523-9144-32a004ad845b" },
                    { 13, "POLICIES", "COMENTARIO_READ", "857e7343-1de0-4523-9144-32a004ad845b" },
                    { 14, "POLICIES", "COMENTARIO_CREATE", "857e7343-1de0-4523-9144-32a004ad845b" }
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
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("0e296de3-1111-4bf7-8d39-f4457c69ec36"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("20a4c079-6f98-4dd1-8b0a-692f25e74614"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("29a40630-651b-40f8-9329-06de3f7c0a88"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("4712eae9-db13-4fb9-afb9-d5f7e52c7fc2"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("6ce019c9-48b8-4872-b323-e8a957970a1d"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("a57db0b7-186a-4661-827b-dc7c8c9a4f46"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("b8344d18-2316-45fc-b64b-b4b805fc8ea8"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("ba5569be-27e0-4f20-9761-b15eafcd962f"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("f81e2341-0e27-463c-87e5-54fe5954de4a"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("0fb2e7b9-f852-4ab1-8c6b-d8edeced411a"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("28e4c349-6123-4da6-ab2a-b662733a370b"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("6378c4d4-16d2-460d-a3c3-6b9ba74e8007"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("82432ed5-a244-4fc3-bdaa-243da6b5fc3e"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("84f2de5f-cc20-4d6b-a31f-69c9952bc84b"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("8f5d2428-397d-485a-b1fd-f2ab542d3df3"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("90e66d1d-cee3-427d-b7f6-d4a37a49c227"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("a924afb7-53d5-472f-aced-738c6645953e"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("b7cb8809-24ac-4e9a-bfb3-af5255706b4b"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("e2ec7094-28ca-48ae-a271-dc50123d742d"));

            migrationBuilder.DeleteData(
                table: "precios",
                keyColumn: "Id",
                keyValue: new Guid("bf8fab3c-8b25-4401-bf5d-f823baac4abb"));

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
        }
    }
}
