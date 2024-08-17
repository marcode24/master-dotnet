using MasterNet.Application.Instructores.GetInstructores;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using static MasterNet.Application.Instructores.GetInstructores.GetInstructoresQuery;

namespace MasterNet.WebApi.Controllers;

[ApiController]
[Route("api/instructores")]
public class InstructoresController : ControllerBase
{
  private readonly ISender _sender;

  public InstructoresController(ISender sender)
  {
    _sender = sender;
  }

  [HttpGet]
  public async Task<IActionResult> PaginationPrecios([FromQuery] GetInstructoresRequest request, CancellationToken cancellationToken)
  {
    var query = new GetInstructoresQueryRequest { InstructoresRequest = request };
    var result = await _sender.Send(query, cancellationToken);

    return result.IsSuccess ? Ok(result.Value) : NotFound();
  }
}