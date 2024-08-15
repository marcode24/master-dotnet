using MasterNet.Application.Cursos.CursoCreate;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using static MasterNet.Application.Cursos.CursoCreate.CursoCreateCommand;

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
  public async Task<ActionResult<Guid>> CursoCreate([FromForm] CursoCreateRequest cursoCreateRequest, CancellationToken cancellationToken)
  {
    var command = new CursoCreateCommandRequest(cursoCreateRequest);
    var result = await _sender.Send(command, cancellationToken);

    return Ok(result);
  }

}