using System.Security.Cryptography.X509Certificates;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MasterNet.Application.Calificaciones.GetCalificaciones;
using MasterNet.Application.Core;
using MasterNet.Application.Instructores.GetInstructores;
using MasterNet.Application.Photos.GetPhoto;
using MasterNet.Application.Precios.GetPrecios;
using MasterNet.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MasterNet.Application.Cursos.GetCurso;

public class GetCursoQuery
{
  public record GetCursoQueryRequest : IRequest<Result<CursoResponse>>
  {
    public Guid Id { get; set; }
  }

  internal class GetCursoQueryHandler : IRequestHandler<GetCursoQueryRequest, Result<CursoResponse>>
  {
    private readonly MasterNetDbContext _context;
    private readonly IMapper _mapper;

    public GetCursoQueryHandler(MasterNetDbContext context, IMapper mapper)
    {
      _context = context;
      _mapper = mapper;
    }

    public async Task<Result<CursoResponse>> Handle(GetCursoQueryRequest request, CancellationToken cancellationToken)
    {
      var curso = await _context.Cursos
        .Where(x => x.Id == request.Id)
        .Include(x => x.Instructores)
        .Include(x => x.Precios)
        .Include(x => x.Calificaciones)
        .ProjectTo<CursoResponse>(_mapper.ConfigurationProvider)
        .FirstOrDefaultAsync(cancellationToken);

      return Result<CursoResponse>.Success(curso!);
    }
  }
}

public record CursoResponse(
  Guid Id,
  string Titulo,
  string Descripcion,
  DateTime FechaPublicacion,
  List<InstructorResponse> Instructores,
  List<CalificacionResponse> Calificaciones,
  List<PrecioResponse> Precios,
  List<PhotoResponse> Photos
);