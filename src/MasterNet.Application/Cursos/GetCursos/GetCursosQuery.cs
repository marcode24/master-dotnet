using System.Linq.Expressions;
using AutoMapper;
using MasterNet.Application.Core;
using MasterNet.Application.Cursos.GetCurso;
using MasterNet.Domain;
using MasterNet.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MasterNet.Application.Cursos.GetCursos;


public class GetCursosQuery
{
  public class GetCursosQueryRequest : IRequest<PagedList<CursoResponse>>
  {
    public GetCursosRequest? CursosRequest { get; set; }
  }

  internal class GetCursosQueryHandler : IRequestHandler<GetCursosQueryRequest, PagedList<CursoResponse>>
  {
    private readonly MasterNetDbContext _context;
    private readonly IMapper _mapper;

    public GetCursosQueryHandler(MasterNetDbContext context, IMapper mapper)
    {
      _context = context;
      _mapper = mapper;
    }

    public Task<PagedList<CursoResponse>> Handle(
      GetCursosQueryRequest request,
      CancellationToken cancellationToken
    )
    {
      IQueryable<Curso> queryable = _context.Cursos!
        .Include(x => x.Instructores)
        .Include(x => x.Precios)
        .Include(x => x.Calificaciones);

      var predicate = ExpressionBuilder.New<Curso>();
      if(!string.IsNullOrEmpty(request.CursosRequest!.Titulo))
        predicate = predicate.And(x => x.Titulo!.ToLower().Contains(request.CursosRequest!.Titulo!.ToLower()));

      if(!string.IsNullOrEmpty(request.CursosRequest!.Descripcion))
        predicate = predicate.And(x => x.Descripcion!.ToLower().Contains(request.CursosRequest!.Descripcion!.ToLower()));

      if(string.IsNullOrEmpty(request.CursosRequest!.OrderBy)) {
        Expression<Func<Curso, object>> orderBy = x => x.Titulo!;
      }
    }
  }
}
