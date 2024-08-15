// using MasterNet.Domain;
// using MasterNet.Persistence;
// using Microsoft.EntityFrameworkCore;

// Console.WriteLine("Hello World!");

// using var context = new MasterNetDbContext();

// var newCurso = new Curso
// {
//   Id = Guid.NewGuid(),
//   Titulo = "Curso de .NET 9",
//   Descripcion = "Bases de programación en .NET 9",
//   FechaPublicacion = DateTime.Now
// };

// context.Add(newCurso);
// await context.SaveChangesAsync();

// var cursos = await context.Cursos.ToListAsync();
// foreach (var curso in cursos)
// {
//   Console.WriteLine($"{curso.Id} : {curso.Titulo}");
// }