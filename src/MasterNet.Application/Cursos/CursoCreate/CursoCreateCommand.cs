using FluentValidation;
using MasterNet.Application.Core;
using MasterNet.Application.Interfaces;
using MasterNet.Domain;
using MasterNet.Persistence;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MasterNet.Application.Cursos.CursoCreate;

public class CursoCreateCommand
{
  public record CursoCreateCommandRequest(CursoCreateRequest CursoCreateRequest) : IRequest<Result<Guid>>, ICommandBase;
  internal class CursoCreateCommandHandler : IRequestHandler<CursoCreateCommandRequest, Result<Guid>>
  {
    private readonly MasterNetDbContext _context;
    private readonly IPhotoService _photoService;

    public CursoCreateCommandHandler(MasterNetDbContext context, IPhotoService photoService)
    {
      _context = context;
      _photoService = photoService;
    }

    public async Task<Result<Guid>> Handle(CursoCreateCommandRequest request, CancellationToken cancellationToken)
    {
      var cursoId = Guid.NewGuid();
      var curso = new Curso
      {
        Id = cursoId,
        Titulo = request.CursoCreateRequest.Titulo,
        Descripcion = request.CursoCreateRequest.Descripcion,
        FechaPublicacion = request.CursoCreateRequest.FechaPublicacion,
      };

      if (request.CursoCreateRequest.Foto is not null)
      {
        var photoUploadResult = await _photoService.AddPhoto(request.CursoCreateRequest.Foto);
        var photo = new Photo
        {
          Id = Guid.NewGuid(),
          Url = photoUploadResult.Url,
          PublicId = photoUploadResult.PublicId,
          CursoId = cursoId,
        };

        curso.Photos = new List<Photo> { photo };
      }

      if (request.CursoCreateRequest.InstructorId is not null)
      {
        var instructor = await _context.Instructores.FirstOrDefaultAsync(x => x.Id == request.CursoCreateRequest.InstructorId, cancellationToken: cancellationToken);
        if (instructor is null)
          return Result<Guid>.Failure("Instructor no encontrado");

        curso.Instructores = new List<Instructor> { instructor };
      }

      if (request.CursoCreateRequest.PrecioId is not null)
      {
        var precio = await _context.Precios.FirstOrDefaultAsync(x => x.Id == request.CursoCreateRequest.PrecioId, cancellationToken: cancellationToken);
        if (precio is null)
          return Result<Guid>.Failure("Precio no encontrado");

        curso.Precios = new List<Precio> { precio };
      }

      _context.Cursos.Add(curso);
      var resultado = await _context.SaveChangesAsync(cancellationToken) > 0;

      return resultado
        ? Result<Guid>.Success(curso.Id)
        : Result<Guid>.Failure("No se pudo crear el curso");
    }
  }

  public class CursoCreateCommandRequestValidator : AbstractValidator<CursoCreateCommandRequest>
  {
    public CursoCreateCommandRequestValidator()
    {
      RuleFor(x => x.CursoCreateRequest)
        .SetValidator(new CursoCreateValidator());
    }
  }
}