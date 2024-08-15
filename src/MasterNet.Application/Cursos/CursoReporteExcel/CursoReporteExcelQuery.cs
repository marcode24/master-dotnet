using MasterNet.Application.Interfaces;
using MasterNet.Domain;
using MasterNet.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MasterNet.Application.Cursos.CursoReporteExcel;

public class CursoReporteExcelQuery
{
  public record CursoReporteExcelQueryRequest() : IRequest<MemoryStream>;

  internal class CursoReporteExcelHandler : IRequestHandler<CursoReporteExcelQueryRequest, MemoryStream>
  {
    private readonly MasterNetDbContext _context;
    private readonly IReportService<Curso> _reportService;

    public CursoReporteExcelHandler(MasterNetDbContext context, IReportService<Curso> reportService)
    {
      _context = context;
      _reportService = reportService;
    }

    public async Task<MemoryStream> Handle(
      CursoReporteExcelQueryRequest request,
      CancellationToken cancellationToken
    )
    {
      var cursos = await _context.Cursos!.Take(10).Skip(0).ToListAsync(cancellationToken);
      return await _reportService.GetCsvReport(cursos);
    }
  }
}