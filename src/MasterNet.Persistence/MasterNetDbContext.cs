using Bogus;
using MasterNet.Domain;
using MasterNet.Persistence.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace MasterNet.Persistence;

public class MasterNetDbContext : IdentityDbContext<AppUser>
{
  public DbSet<Curso> Cursos { get; set; }
  public DbSet<Instructor> Instructores { get; set; }
  public DbSet<Precio> Precios { get; set; }
  public DbSet<Calificacion> Calificaciones { get; set; }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    optionsBuilder.UseSqlite("Data Source=LocalDatabase.db")
      .LogTo(
        Console.WriteLine,
        new[] { DbLoggerCategory.Database.Command.Name },
        LogLevel.Information
      ).EnableSensitiveDataLogging();
  }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);

    modelBuilder.Entity<Curso>().ToTable("cursos");
    modelBuilder.Entity<Instructor>().ToTable("instructores");
    modelBuilder.Entity<CursoInstructor>().ToTable("cursos_instructores");
    modelBuilder.Entity<Precio>().ToTable("precios");
    modelBuilder.Entity<CursoPrecio>().ToTable("cursos_precios");
    modelBuilder.Entity<Calificacion>().ToTable("calificaciones");
    modelBuilder.Entity<Photo>().ToTable("imagenes");

    modelBuilder.Entity<Precio>()
      .Property(p => p.PrecioPromocion)
      .HasPrecision(10, 2);

    modelBuilder.Entity<Precio>()
      .Property(p => p.PrecioActual)
      .HasPrecision(10, 2);

    modelBuilder.Entity<Precio>()
      .Property(b => b.Nombre)
      .HasColumnType("VARCHAR")
      .HasMaxLength(250);

    modelBuilder.Entity<Curso>()
      .HasMany(m => m.Photos)
      .WithOne(m => m.Curso)
      .HasForeignKey(m => m.CursoId)
      .IsRequired()
      .OnDelete(DeleteBehavior.Cascade); // Si se borra un curso, se borran las fotos

    modelBuilder.Entity<Curso>()
      .HasMany(m => m.Calificaciones)
      .WithOne(m => m.Curso)
      .HasForeignKey(m => m.CursoId)
      .OnDelete(DeleteBehavior.Restrict); // Si se llega a borrar un curso, las calificaciones se mantienen

    modelBuilder.Entity<Curso>()
      .HasMany(m => m.Precios)
      .WithMany(m => m.Cursos)
      .UsingEntity<CursoPrecio>(
        j => j
          .HasOne(p => p.Precio)
          .WithMany(p => p.CursoPrecios)
          .HasForeignKey(p => p.PrecioId),
        j => j
          .HasOne(p => p.Curso)
          .WithMany(p => p.CursoPrecios)
          .HasForeignKey(p => p.CursoId),
        j => { j.HasKey(t => new { t.CursoId, t.PrecioId }); } // Llave primaria compuesta
      );

    modelBuilder.Entity<Curso>()
      .HasMany(m => m.Instructores)
      .WithMany(m => m.Cursos)
      .UsingEntity<CursoInstructor>(
        j => j
          .HasOne(p => p.Instructor)
          .WithMany(p => p.CursoInstructores)
          .HasForeignKey(p => p.InstructorId),
        j => j
          .HasOne(p => p.Curso)
          .WithMany(p => p.CursoInstructores)
          .HasForeignKey(p => p.CursoId),
        j => { j.HasKey(t => new { t.CursoId, t.InstructorId }); } // Llave primaria compuesta
      );

    modelBuilder.Entity<Curso>()
      .HasData(DataMaster().Item1);

    modelBuilder.Entity<Precio>()
      .HasData(DataMaster().Item2);

    modelBuilder.Entity<Instructor>()
      .HasData(DataMaster().Item3);

    CargarDataSeguridad(modelBuilder);
  }

  private void CargarDataSeguridad(ModelBuilder modelBuilder)
  {
    var adminId = Guid.NewGuid().ToString();
    var clientId = Guid.NewGuid().ToString();

    modelBuilder.Entity<IdentityRole>()
      .HasData(
        new IdentityRole {
          Id = adminId,
          Name = CustomRoles.ADMIN,
          NormalizedName = CustomRoles.ADMIN
        }
      );

    modelBuilder.Entity<IdentityRole>()
      .HasData(
        new IdentityRole {
          Id = clientId,
          Name = CustomRoles.CLIENTE,
          NormalizedName = CustomRoles.CLIENTE,
        }
      );

    modelBuilder.Entity<IdentityRoleClaim<string>>()
      .HasData(
        new IdentityRoleClaim<string> {
          Id = 1,
          ClaimType = CustomClaims.POLICIES,
          ClaimValue = PolicyMaster.CURSO_READ,
          RoleId = adminId,
        },
        new IdentityRoleClaim<string> {
          Id = 2,
          ClaimType = CustomClaims.POLICIES,
          ClaimValue = PolicyMaster.CURSO_UPDATE,
          RoleId = adminId,
        },
        new IdentityRoleClaim<string> {
          Id = 3,
          ClaimType = CustomClaims.POLICIES,
          ClaimValue = PolicyMaster.CURSO_WRITE,
          RoleId = adminId,
        },
        new IdentityRoleClaim<string> {
          Id = 4,
          ClaimType = CustomClaims.POLICIES,
          ClaimValue = PolicyMaster.CURSO_DELETE,
          RoleId = adminId,
        },
        new IdentityRoleClaim<string> {
          Id = 5,
          ClaimType = CustomClaims.POLICIES,
          ClaimValue = PolicyMaster.INSTRUCTOR_CREATE,
          RoleId = adminId,
        },
        new IdentityRoleClaim<string> {
          Id = 6,
          ClaimType = CustomClaims.POLICIES,
          ClaimValue = PolicyMaster.INSTRUCTOR_READ,
          RoleId = adminId,
        },
        new IdentityRoleClaim<string> {
          Id = 7,
          ClaimType = CustomClaims.POLICIES,
          ClaimValue = PolicyMaster.INSTRUCTOR_UPDATE,
          RoleId = adminId,
        },
        new IdentityRoleClaim<string> {
          Id = 8,
          ClaimType = CustomClaims.POLICIES,
          ClaimValue = PolicyMaster.COMENTARIO_READ,
          RoleId = adminId,
        },
        new IdentityRoleClaim<string> {
          Id = 9,
          ClaimType = CustomClaims.POLICIES,
          ClaimValue = PolicyMaster.COMENTARIO_DELETE,
          RoleId = adminId,
        },
        new IdentityRoleClaim<string> {
          Id = 10,
          ClaimType = CustomClaims.POLICIES,
          ClaimValue = PolicyMaster.COMENTARIO_CREATE,
          RoleId = adminId,
        },
        new IdentityRoleClaim<string> {
          Id = 11,
          ClaimType = CustomClaims.POLICIES,
          ClaimValue = PolicyMaster.CURSO_READ,
          RoleId = clientId,
        },
        new IdentityRoleClaim<string> {
          Id = 12,
          ClaimType = CustomClaims.POLICIES,
          ClaimValue = PolicyMaster.INSTRUCTOR_READ,
          RoleId = clientId,
        },
        new IdentityRoleClaim<string> {
          Id = 13,
          ClaimType = CustomClaims.POLICIES,
          ClaimValue = PolicyMaster.COMENTARIO_READ,
          RoleId = clientId,
        },
        new IdentityRoleClaim<string> {
          Id = 14,
          ClaimType = CustomClaims.POLICIES,
          ClaimValue = PolicyMaster.COMENTARIO_CREATE,
          RoleId = clientId,
        }
      );
  }

  private Tuple<Curso[], Precio[], Instructor[]> DataMaster()
  {
    var cursos = new List<Curso>();
    var faker = new Faker();

    for (var i = 1; i < 10; i++)
    {
      var cursoId = Guid.NewGuid();
      cursos.Add(
        new Curso
        {
          Id = cursoId,
          Descripcion = faker.Commerce.ProductDescription(),
          Titulo = faker.Commerce.ProductName(),
          FechaPublicacion = DateTime.UtcNow,
        }
      );
    }

    var precioId = Guid.NewGuid();
    var precio = new Precio
    {
      Id = precioId,
      PrecioActual = 10.0m,
      PrecioPromocion = 8.0m,
      Nombre = "Precio regular",
    };
    var precios = new List<Precio> { precio };

    var fakerInstructor = new Faker<Instructor>()
      .RuleFor(t => t.Id, _ => Guid.NewGuid())
      .RuleFor(t => t.Nombre, f => f.Name.FullName())
      .RuleFor(t => t.Apeliidos, f => f.Name.LastName())
      .RuleFor(t => t.Grado, f => f.Name.JobTitle());

    var instructores = fakerInstructor.Generate(10);

    return Tuple.Create(cursos.ToArray(), precios.ToArray(), instructores.ToArray());
  }
}