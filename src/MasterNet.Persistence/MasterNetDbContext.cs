using MasterNet.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace MasterNet.Persistence;

public class MasterNetDbContext : DbContext
{
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
  }
}