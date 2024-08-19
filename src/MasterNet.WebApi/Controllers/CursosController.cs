using MasterNet.Application.Core;
using MasterNet.Application.Cursos.CursoCreate;
using MasterNet.Application.Cursos.CursoUpdate;
using MasterNet.Application.Cursos.GetCursos;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static MasterNet.Application.Cursos.CursoCreate.CursoCreateCommand;
using static MasterNet.Application.Cursos.CursoDelete.CursoDeleteCommand;
using static MasterNet.Application.Cursos.CursoReporteExcel.CursoReporteExcelQuery;
using static MasterNet.Application.Cursos.CursoUpdate.CursoUpdateCommand;
using static MasterNet.Application.Cursos.GetCurso.GetCursoQuery;
using static MasterNet.Application.Cursos.GetCursos.GetCursosQuery;

namespace MasterNet.WebApi.Controllers;

[ApiController]
[Authorize]
[Route("api/cursos")]
public class CursosController : ControllerBase
{
  private readonly ISender _sender;

  public CursosController(ISender sender)
  {
    _sender = sender;
  }

  [HttpGet]
  public async Task<ActionResult> PaginationCursos([FromQuery] GetCursosRequest request, CancellationToken cancellationToken)
  {
    var query = new GetCursosQueryRequest { CursosRequest = request };
    var result = await _sender.Send(query, cancellationToken);

    return result.IsSuccess ? Ok(result.Value) : NotFound();
  }

  [HttpPost("create")]
  public async Task<ActionResult<Result<Guid>>> CursoCreate([FromForm] CursoCreateRequest cursoCreateRequest, CancellationToken cancellationToken)
  {
    var command = new CursoCreateCommandRequest(cursoCreateRequest);

    return await _sender.Send(command, cancellationToken);
  }

  [HttpPut("{id}")]
  public async Task<ActionResult<Result<Guid>>> CursoUpdate(Guid id, [FromBody] CursoUpdateRequest cursoUpdateRequest, CancellationToken cancellationToken)
  {
    var command = new CursoUpdateCommandRequest(cursoUpdateRequest, id);
    var result = await _sender.Send(command, cancellationToken);

    return result.IsSuccess ? Ok(result.Value) : NotFound();
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

  [HttpDelete("{id}")]
  public async Task<ActionResult<Result<Unit>>> CursoDelete(Guid id, CancellationToken cancellationToken)
  {
    var command = new CursoDeleteCommandRequest(id);
    var result = await _sender.Send(command, cancellationToken);

    return result.IsSuccess ? Ok(result.Value) : NotFound();
  }

}