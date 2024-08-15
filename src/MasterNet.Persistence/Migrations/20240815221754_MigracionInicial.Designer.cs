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
    [Migration("20240815221754_MigracionInicial")]
    partial class MigracionInicial
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
                            Id = new Guid("5aacba3b-05e5-4cf2-84d7-054568040934"),
                            Descripcion = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            FechaPublicacion = new DateTime(2024, 8, 15, 22, 17, 54, 166, DateTimeKind.Utc).AddTicks(1303),
                            Titulo = "Ergonomic Frozen Shoes"
                        },
                        new
                        {
                            Id = new Guid("ad4de404-9187-4959-a2e4-358362bc4ce4"),
                            Descripcion = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                            FechaPublicacion = new DateTime(2024, 8, 15, 22, 17, 54, 166, DateTimeKind.Utc).AddTicks(1417),
                            Titulo = "Small Concrete Ball"
                        },
                        new
                        {
                            Id = new Guid("03acd1dc-62ce-4a2d-8d35-178ff9aa3b06"),
                            Descripcion = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            FechaPublicacion = new DateTime(2024, 8, 15, 22, 17, 54, 166, DateTimeKind.Utc).AddTicks(1442),
                            Titulo = "Generic Cotton Gloves"
                        },
                        new
                        {
                            Id = new Guid("992af6a3-b8a0-43c6-8743-a8efc2c4ace9"),
                            Descripcion = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            FechaPublicacion = new DateTime(2024, 8, 15, 22, 17, 54, 166, DateTimeKind.Utc).AddTicks(1462),
                            Titulo = "Handcrafted Wooden Chicken"
                        },
                        new
                        {
                            Id = new Guid("735fa748-cbd8-463d-9738-ac47c233f071"),
                            Descripcion = "The Football Is Good For Training And Recreational Purposes",
                            FechaPublicacion = new DateTime(2024, 8, 15, 22, 17, 54, 166, DateTimeKind.Utc).AddTicks(1482),
                            Titulo = "Generic Rubber Computer"
                        },
                        new
                        {
                            Id = new Guid("9b47dd9d-9088-495c-92ea-e91652ef461b"),
                            Descripcion = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            FechaPublicacion = new DateTime(2024, 8, 15, 22, 17, 54, 166, DateTimeKind.Utc).AddTicks(1502),
                            Titulo = "Small Granite Chips"
                        },
                        new
                        {
                            Id = new Guid("e5c9edea-fcb3-495e-9ab7-bbd41236bee8"),
                            Descripcion = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            FechaPublicacion = new DateTime(2024, 8, 15, 22, 17, 54, 166, DateTimeKind.Utc).AddTicks(1532),
                            Titulo = "Practical Rubber Soap"
                        },
                        new
                        {
                            Id = new Guid("3c6d24a5-0bd2-4393-a16e-d5478b47d415"),
                            Descripcion = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",
                            FechaPublicacion = new DateTime(2024, 8, 15, 22, 17, 54, 166, DateTimeKind.Utc).AddTicks(1550),
                            Titulo = "Rustic Cotton Bike"
                        },
                        new
                        {
                            Id = new Guid("da613ac0-8665-47a0-b932-60c91727c06f"),
                            Descripcion = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",
                            FechaPublicacion = new DateTime(2024, 8, 15, 22, 17, 54, 166, DateTimeKind.Utc).AddTicks(1569),
                            Titulo = "Incredible Soft Computer"
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
                            Id = new Guid("584dcc85-a5b9-48ea-9a7e-2dc689353b6e"),
                            Apeliidos = "Brekke",
                            Grado = "Future Security Director",
                            Nombre = "Estefania Lueilwitz"
                        },
                        new
                        {
                            Id = new Guid("e07144d3-b024-4ace-a403-62e604397511"),
                            Apeliidos = "Zieme",
                            Grado = "Global Branding Orchestrator",
                            Nombre = "Maymie Pfeffer"
                        },
                        new
                        {
                            Id = new Guid("a00a2750-128c-4489-89a0-131684d546f0"),
                            Apeliidos = "Davis",
                            Grado = "Direct Marketing Orchestrator",
                            Nombre = "Ezra Corkery"
                        },
                        new
                        {
                            Id = new Guid("6dce1e48-c971-4bef-a6cc-2fff55ff24d8"),
                            Apeliidos = "Waters",
                            Grado = "Future Directives Administrator",
                            Nombre = "Aglae Schoen"
                        },
                        new
                        {
                            Id = new Guid("264b7b09-73fb-4686-8fd8-822a3ac2ecc9"),
                            Apeliidos = "Waelchi",
                            Grado = "Forward Tactics Orchestrator",
                            Nombre = "Cristobal Cronin"
                        },
                        new
                        {
                            Id = new Guid("8257497b-6604-4889-b21b-b288a542850d"),
                            Apeliidos = "Rau",
                            Grado = "Corporate Marketing Producer",
                            Nombre = "Zella Hahn"
                        },
                        new
                        {
                            Id = new Guid("9109ece1-3d35-4bd9-acd6-663220e10411"),
                            Apeliidos = "Borer",
                            Grado = "National Mobility Architect",
                            Nombre = "Ezra Bayer"
                        },
                        new
                        {
                            Id = new Guid("9476d091-e8b4-41d6-bd5f-fb09a9eee9f0"),
                            Apeliidos = "Predovic",
                            Grado = "Product Accountability Planner",
                            Nombre = "Janet Jones"
                        },
                        new
                        {
                            Id = new Guid("e00c1057-4869-42bb-9692-c9865f955df1"),
                            Apeliidos = "Carroll",
                            Grado = "Global Communications Specialist",
                            Nombre = "Elta Kshlerin"
                        },
                        new
                        {
                            Id = new Guid("b0ade233-b523-4f44-9642-aba8308e1f89"),
                            Apeliidos = "Wehner",
                            Grado = "Central Identity Technician",
                            Nombre = "Norris Kling"
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
                            Id = new Guid("74b5309c-a0f6-4a9b-87af-6bb66aca389f"),
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
                            Id = "920a5681-1a15-4d07-a328-099ae525f036",
                            Name = "ADMIN",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "0cab0dfa-71b8-4b9b-a88c-98fe2a400072",
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
                            RoleId = "920a5681-1a15-4d07-a328-099ae525f036"
                        },
                        new
                        {
                            Id = 2,
                            ClaimType = "POLICIES",
                            ClaimValue = "CURSO_UPDATE",
                            RoleId = "920a5681-1a15-4d07-a328-099ae525f036"
                        },
                        new
                        {
                            Id = 3,
                            ClaimType = "POLICIES",
                            ClaimValue = "CURSO_WRITE",
                            RoleId = "920a5681-1a15-4d07-a328-099ae525f036"
                        },
                        new
                        {
                            Id = 4,
                            ClaimType = "POLICIES",
                            ClaimValue = "CURSO_DELETE",
                            RoleId = "920a5681-1a15-4d07-a328-099ae525f036"
                        },
                        new
                        {
                            Id = 5,
                            ClaimType = "POLICIES",
                            ClaimValue = "INSTRUCTOR_CREATE",
                            RoleId = "920a5681-1a15-4d07-a328-099ae525f036"
                        },
                        new
                        {
                            Id = 6,
                            ClaimType = "POLICIES",
                            ClaimValue = "INSTRUCTOR_READ",
                            RoleId = "920a5681-1a15-4d07-a328-099ae525f036"
                        },
                        new
                        {
                            Id = 7,
                            ClaimType = "POLICIES",
                            ClaimValue = "INSTRUCTOR_UPDATE",
                            RoleId = "920a5681-1a15-4d07-a328-099ae525f036"
                        },
                        new
                        {
                            Id = 8,
                            ClaimType = "POLICIES",
                            ClaimValue = "COMENTARIO_READ",
                            RoleId = "920a5681-1a15-4d07-a328-099ae525f036"
                        },
                        new
                        {
                            Id = 9,
                            ClaimType = "POLICIES",
                            ClaimValue = "COMENTARIO_DELETE",
                            RoleId = "920a5681-1a15-4d07-a328-099ae525f036"
                        },
                        new
                        {
                            Id = 10,
                            ClaimType = "POLICIES",
                            ClaimValue = "COMENTARIO_CREATE",
                            RoleId = "920a5681-1a15-4d07-a328-099ae525f036"
                        },
                        new
                        {
                            Id = 11,
                            ClaimType = "POLICIES",
                            ClaimValue = "CURSO_READ",
                            RoleId = "0cab0dfa-71b8-4b9b-a88c-98fe2a400072"
                        },
                        new
                        {
                            Id = 12,
                            ClaimType = "POLICIES",
                            ClaimValue = "INSTRUCTOR_READ",
                            RoleId = "0cab0dfa-71b8-4b9b-a88c-98fe2a400072"
                        },
                        new
                        {
                            Id = 13,
                            ClaimType = "POLICIES",
                            ClaimValue = "COMENTARIO_READ",
                            RoleId = "0cab0dfa-71b8-4b9b-a88c-98fe2a400072"
                        },
                        new
                        {
                            Id = 14,
                            ClaimType = "POLICIES",
                            ClaimValue = "COMENTARIO_CREATE",
                            RoleId = "0cab0dfa-71b8-4b9b-a88c-98fe2a400072"
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
