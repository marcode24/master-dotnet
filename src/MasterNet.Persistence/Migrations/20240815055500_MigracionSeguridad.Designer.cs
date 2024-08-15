﻿// <auto-generated />
using System;
using MasterNet.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MasterNet.Persistence.Migrations
{
    [DbContext(typeof(MasterNetDbContext))]
    [Migration("20240815055500_MigracionSeguridad")]
    partial class MigracionSeguridad
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("MasterNet.Domain.Calificacion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Alumno")
                        .HasColumnType("TEXT");

                    b.Property<string>("Comentario")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CursoId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Puntaje")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CursoId");

                    b.ToTable("calificaciones", (string)null);
                });

            modelBuilder.Entity("MasterNet.Domain.Curso", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaPublicacion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Titulo")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("cursos", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("20a4c079-6f98-4dd1-8b0a-692f25e74614"),
                            Descripcion = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            FechaPublicacion = new DateTime(2024, 8, 15, 5, 55, 0, 432, DateTimeKind.Utc).AddTicks(9596),
                            Titulo = "Ergonomic Granite Chips"
                        },
                        new
                        {
                            Id = new Guid("29a40630-651b-40f8-9329-06de3f7c0a88"),
                            Descripcion = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            FechaPublicacion = new DateTime(2024, 8, 15, 5, 55, 0, 432, DateTimeKind.Utc).AddTicks(9617),
                            Titulo = "Refined Granite Ball"
                        },
                        new
                        {
                            Id = new Guid("a57db0b7-186a-4661-827b-dc7c8c9a4f46"),
                            Descripcion = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            FechaPublicacion = new DateTime(2024, 8, 15, 5, 55, 0, 432, DateTimeKind.Utc).AddTicks(9630),
                            Titulo = "Small Wooden Fish"
                        },
                        new
                        {
                            Id = new Guid("6ce019c9-48b8-4872-b323-e8a957970a1d"),
                            Descripcion = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            FechaPublicacion = new DateTime(2024, 8, 15, 5, 55, 0, 432, DateTimeKind.Utc).AddTicks(9641),
                            Titulo = "Sleek Steel Pants"
                        },
                        new
                        {
                            Id = new Guid("b8344d18-2316-45fc-b64b-b4b805fc8ea8"),
                            Descripcion = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            FechaPublicacion = new DateTime(2024, 8, 15, 5, 55, 0, 432, DateTimeKind.Utc).AddTicks(9668),
                            Titulo = "Practical Rubber Towels"
                        },
                        new
                        {
                            Id = new Guid("f81e2341-0e27-463c-87e5-54fe5954de4a"),
                            Descripcion = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            FechaPublicacion = new DateTime(2024, 8, 15, 5, 55, 0, 432, DateTimeKind.Utc).AddTicks(9685),
                            Titulo = "Practical Plastic Cheese"
                        },
                        new
                        {
                            Id = new Guid("0e296de3-1111-4bf7-8d39-f4457c69ec36"),
                            Descripcion = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            FechaPublicacion = new DateTime(2024, 8, 15, 5, 55, 0, 432, DateTimeKind.Utc).AddTicks(9697),
                            Titulo = "Incredible Concrete Hat"
                        },
                        new
                        {
                            Id = new Guid("4712eae9-db13-4fb9-afb9-d5f7e52c7fc2"),
                            Descripcion = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            FechaPublicacion = new DateTime(2024, 8, 15, 5, 55, 0, 432, DateTimeKind.Utc).AddTicks(9740),
                            Titulo = "Refined Plastic Fish"
                        },
                        new
                        {
                            Id = new Guid("ba5569be-27e0-4f20-9761-b15eafcd962f"),
                            Descripcion = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            FechaPublicacion = new DateTime(2024, 8, 15, 5, 55, 0, 432, DateTimeKind.Utc).AddTicks(9751),
                            Titulo = "Ergonomic Cotton Table"
                        });
                });

            modelBuilder.Entity("MasterNet.Domain.CursoInstructor", b =>
                {
                    b.Property<Guid>("CursoId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("InstructorId")
                        .HasColumnType("TEXT");

                    b.HasKey("CursoId", "InstructorId");

                    b.HasIndex("InstructorId");

                    b.ToTable("cursos_instructores", (string)null);
                });

            modelBuilder.Entity("MasterNet.Domain.CursoPrecio", b =>
                {
                    b.Property<Guid>("CursoId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("PrecioId")
                        .HasColumnType("TEXT");

                    b.HasKey("CursoId", "PrecioId");

                    b.HasIndex("PrecioId");

                    b.ToTable("cursos_precios", (string)null);
                });

            modelBuilder.Entity("MasterNet.Domain.Instructor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Apeliidos")
                        .HasColumnType("TEXT");

                    b.Property<string>("Grado")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("instructores", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("82432ed5-a244-4fc3-bdaa-243da6b5fc3e"),
                            Apeliidos = "Hickle",
                            Grado = "District Mobility Officer",
                            Nombre = "Hassan Heathcote"
                        },
                        new
                        {
                            Id = new Guid("84f2de5f-cc20-4d6b-a31f-69c9952bc84b"),
                            Apeliidos = "Schuppe",
                            Grado = "Regional Group Officer",
                            Nombre = "Anastasia Boehm"
                        },
                        new
                        {
                            Id = new Guid("8f5d2428-397d-485a-b1fd-f2ab542d3df3"),
                            Apeliidos = "Abernathy",
                            Grado = "National Brand Technician",
                            Nombre = "Johnny Abernathy"
                        },
                        new
                        {
                            Id = new Guid("e2ec7094-28ca-48ae-a271-dc50123d742d"),
                            Apeliidos = "Brakus",
                            Grado = "Investor Brand Developer",
                            Nombre = "Pascale Emmerich"
                        },
                        new
                        {
                            Id = new Guid("90e66d1d-cee3-427d-b7f6-d4a37a49c227"),
                            Apeliidos = "Steuber",
                            Grado = "Lead Usability Assistant",
                            Nombre = "Moshe Schaefer"
                        },
                        new
                        {
                            Id = new Guid("28e4c349-6123-4da6-ab2a-b662733a370b"),
                            Apeliidos = "Howe",
                            Grado = "Future Branding Strategist",
                            Nombre = "Lester Lang"
                        },
                        new
                        {
                            Id = new Guid("6378c4d4-16d2-460d-a3c3-6b9ba74e8007"),
                            Apeliidos = "Maggio",
                            Grado = "Future Accountability Representative",
                            Nombre = "Kylee Pagac"
                        },
                        new
                        {
                            Id = new Guid("0fb2e7b9-f852-4ab1-8c6b-d8edeced411a"),
                            Apeliidos = "Tromp",
                            Grado = "Global Applications Executive",
                            Nombre = "Eve Vandervort"
                        },
                        new
                        {
                            Id = new Guid("a924afb7-53d5-472f-aced-738c6645953e"),
                            Apeliidos = "McCullough",
                            Grado = "Internal Mobility Engineer",
                            Nombre = "Elinor Jacobs"
                        },
                        new
                        {
                            Id = new Guid("b7cb8809-24ac-4e9a-bfb3-af5255706b4b"),
                            Apeliidos = "Haley",
                            Grado = "Investor Accountability Coordinator",
                            Nombre = "Rahul Lindgren"
                        });
                });

            modelBuilder.Entity("MasterNet.Domain.Photo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CursoId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CursoId");

                    b.ToTable("imagenes", (string)null);
                });

            modelBuilder.Entity("MasterNet.Domain.Precio", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasMaxLength(250)
                        .HasColumnType("VARCHAR");

                    b.Property<decimal>("PrecioActual")
                        .HasPrecision(10, 2)
                        .HasColumnType("TEXT");

                    b.Property<decimal>("PrecioPromocion")
                        .HasPrecision(10, 2)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("precios", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("bf8fab3c-8b25-4401-bf5d-f823baac4abb"),
                            Nombre = "Precio regular",
                            PrecioActual = 10.0m,
                            PrecioPromocion = 8.0m
                        });
                });

            modelBuilder.Entity("MasterNet.Persistence.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Carrera")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NombreCompleto")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "72361dc2-1c3d-4046-9ed1-1057e9b26563",
                            Name = "ADMIN",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "857e7343-1de0-4523-9144-32a004ad845b",
                            Name = "CLIENTE",
                            NormalizedName = "CLIENTE"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClaimType = "POLICIES",
                            ClaimValue = "CURSO_READ",
                            RoleId = "72361dc2-1c3d-4046-9ed1-1057e9b26563"
                        },
                        new
                        {
                            Id = 2,
                            ClaimType = "POLICIES",
                            ClaimValue = "CURSO_UPDATE",
                            RoleId = "72361dc2-1c3d-4046-9ed1-1057e9b26563"
                        },
                        new
                        {
                            Id = 3,
                            ClaimType = "POLICIES",
                            ClaimValue = "CURSO_WRITE",
                            RoleId = "72361dc2-1c3d-4046-9ed1-1057e9b26563"
                        },
                        new
                        {
                            Id = 4,
                            ClaimType = "POLICIES",
                            ClaimValue = "CURSO_DELETE",
                            RoleId = "72361dc2-1c3d-4046-9ed1-1057e9b26563"
                        },
                        new
                        {
                            Id = 5,
                            ClaimType = "POLICIES",
                            ClaimValue = "INSTRUCTOR_CREATE",
                            RoleId = "72361dc2-1c3d-4046-9ed1-1057e9b26563"
                        },
                        new
                        {
                            Id = 6,
                            ClaimType = "POLICIES",
                            ClaimValue = "INSTRUCTOR_READ",
                            RoleId = "72361dc2-1c3d-4046-9ed1-1057e9b26563"
                        },
                        new
                        {
                            Id = 7,
                            ClaimType = "POLICIES",
                            ClaimValue = "INSTRUCTOR_UPDATE",
                            RoleId = "72361dc2-1c3d-4046-9ed1-1057e9b26563"
                        },
                        new
                        {
                            Id = 8,
                            ClaimType = "POLICIES",
                            ClaimValue = "COMENTARIO_READ",
                            RoleId = "72361dc2-1c3d-4046-9ed1-1057e9b26563"
                        },
                        new
                        {
                            Id = 9,
                            ClaimType = "POLICIES",
                            ClaimValue = "COMENTARIO_DELETE",
                            RoleId = "72361dc2-1c3d-4046-9ed1-1057e9b26563"
                        },
                        new
                        {
                            Id = 10,
                            ClaimType = "POLICIES",
                            ClaimValue = "COMENTARIO_CREATE",
                            RoleId = "72361dc2-1c3d-4046-9ed1-1057e9b26563"
                        },
                        new
                        {
                            Id = 11,
                            ClaimType = "POLICIES",
                            ClaimValue = "CURSO_READ",
                            RoleId = "857e7343-1de0-4523-9144-32a004ad845b"
                        },
                        new
                        {
                            Id = 12,
                            ClaimType = "POLICIES",
                            ClaimValue = "INSTRUCTOR_READ",
                            RoleId = "857e7343-1de0-4523-9144-32a004ad845b"
                        },
                        new
                        {
                            Id = 13,
                            ClaimType = "POLICIES",
                            ClaimValue = "COMENTARIO_READ",
                            RoleId = "857e7343-1de0-4523-9144-32a004ad845b"
                        },
                        new
                        {
                            Id = 14,
                            ClaimType = "POLICIES",
                            ClaimValue = "COMENTARIO_CREATE",
                            RoleId = "857e7343-1de0-4523-9144-32a004ad845b"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("MasterNet.Domain.Calificacion", b =>
                {
                    b.HasOne("MasterNet.Domain.Curso", "Curso")
                        .WithMany("Calificaciones")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Curso");
                });

            modelBuilder.Entity("MasterNet.Domain.CursoInstructor", b =>
                {
                    b.HasOne("MasterNet.Domain.Curso", "Curso")
                        .WithMany("CursoInstructores")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MasterNet.Domain.Instructor", "Instructor")
                        .WithMany("CursoInstructores")
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Curso");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("MasterNet.Domain.CursoPrecio", b =>
                {
                    b.HasOne("MasterNet.Domain.Curso", "Curso")
                        .WithMany("CursoPrecios")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MasterNet.Domain.Precio", "Precio")
                        .WithMany("CursoPrecios")
                        .HasForeignKey("PrecioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Curso");

                    b.Navigation("Precio");
                });

            modelBuilder.Entity("MasterNet.Domain.Photo", b =>
                {
                    b.HasOne("MasterNet.Domain.Curso", "Curso")
                        .WithMany("Photos")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Curso");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("MasterNet.Persistence.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("MasterNet.Persistence.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MasterNet.Persistence.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("MasterNet.Persistence.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MasterNet.Domain.Curso", b =>
                {
                    b.Navigation("Calificaciones");

                    b.Navigation("CursoInstructores");

                    b.Navigation("CursoPrecios");

                    b.Navigation("Photos");
                });

            modelBuilder.Entity("MasterNet.Domain.Instructor", b =>
                {
                    b.Navigation("CursoInstructores");
                });

            modelBuilder.Entity("MasterNet.Domain.Precio", b =>
                {
                    b.Navigation("CursoPrecios");
                });
#pragma warning restore 612, 618
        }
    }
}