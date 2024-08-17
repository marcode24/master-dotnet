using System.Linq.Expressions;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MasterNet.Application.Core;
using MasterNet.Domain;
using MasterNet.Persistence;
using MediatR;

namespace MasterNet.Application.Calificaciones.GetCalificaciones;

public class GetCalificacionesQuery
{
  public record GetCalificacionesQueryRequest : IRequest<Result<PagedList<CalificacionResponse>>>
  {
    public GetCalificacionesRequest? CalificacionesRequest { get; set; }
  }

  internal class GetCalificacionesQueryHandler : IRequestHandler<GetCalificacionesQueryRequest, Result<PagedList<CalificacionResponse>>>
  {
    private readonly MasterNetDbContext _context;
    private readonly IMapper _mapper;

    public GetCalificacionesQueryHandler(MasterNetDbContext context, IMapper mapper)
    {
      _context = context;
      _mapper = mapper;
    }
    public async Task<Result<PagedList<CalificacionResponse>>> Handle(GetCalificacionesQueryRequest request, CancellationToken cancellationToken)
    {
      IQueryable<Calificacion> queryable = _context.Calificaciones!;
      var predicate = ExpressionBuilder.New<Calificacion>();

      if (!string.IsNullOrEmpty(request.CalificacionesRequest!.Alumno))
        predicate = predicate.And(x => x.Alumno!.ToLower().Contains(request.CalificacionesRequest!.Alumno!.ToLower()));

      if (request.CalificacionesRequest!.CursoId is not null)
        predicate = predicate.And(x => x.CursoId == request.CalificacionesRequest!.CursoId);

      if (string.IsNullOrEmpty(request.CalificacionesRequest!.OrderBy))
      {
        Expression<Func<Calificacion, object>> orderBySelector = request.CalificacionesRequest.OrderBy!.ToLower() switch
        {
          "alumno" => x => x.Alumno!,
          "curso" => x => x.CursoId!,
          _ => x => x.Alumno!
        };

        bool orderBy = request.CalificacionesRequest.OrderAsc ?? true;

        queryable = orderBy
          ? queryable.OrderBy(orderBySelector)
          : queryable.OrderByDescending(orderBySelector);
      }

      queryable = queryable.Where(predicate);
      var calificacionesQuery = queryable
        .ProjectTo<CalificacionResponse>(_mapper.ConfigurationProvider)
        .AsQueryable();

      var pagination = await PagedList<CalificacionResponse>.CreateAsync(
        calificacionesQuery,
        request.CalificacionesRequest!.PageNumber,
        request.CalificacionesRequest!.PageSize
      );

      return Result<PagedList<CalificacionResponse>>.Success(pagination);
    }
  }
}

public record CalificacionResponse(
  string? Alumno,
  int? Puntaje,
  string? Comentario,
  string? NombreCurso
)
{
  public CalificacionResponse() : this(null, null, null, null) { }
}