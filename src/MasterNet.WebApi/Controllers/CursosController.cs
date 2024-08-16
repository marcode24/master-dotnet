using MasterNet.Application.Core;
using MasterNet.Application.Cursos.CursoCreate;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using static MasterNet.Application.Cursos.CursoCreate.CursoCreateCommand;
using static MasterNet.Application.Cursos.CursoReporteExcel.CursoReporteExcelQuery;
using static MasterNet.Application.Cursos.GetCurso.GetCursoQuery;

namespace MasterNet.WebApi.Controllers;

[ApiController]
[Route("api/cursos")]
public class CursosController : ControllerBase
{
  private readonly ISender _sender;

  public CursosController(ISender sender)
  {
    _sender = sender;
  }

  [HttpPost("create")]
  public async Task<ActionResult<Result<Guid>>> CursoCreate([FromForm] CursoCreateRequest cursoCreateRequest, CancellationToken cancellationToken)
  {
    var command = new CursoCreateCommandRequest(cursoCreateRequest);

    return await _sender.Send(command, cancellationToken);
  }

  [HttpGet("{id}")]
  public async Task<IActionResult> GetCurso(Guid id, CancellationToken cancellationToken)
  {
    var query = new GetCursoQueryRequest { Id = id };
    var result = await _sender.Send(query, cancellationToken);

    return result.IsSuccess ? Ok(result.Value) : NotFound();
  }

  [HttpGet("reporte")]
  public async Task<IActionResult> ReporteCSV(CancellationToken cancellationToken)
  {
    var query = new CursoReporteExcelQueryRequest();
    var result = await _sender.Send(query, cancellationToken);
    byte[] excelBytes = result.ToArray();

    return File(excelBytes, "text/csv", "cursos.csv");
  }

}