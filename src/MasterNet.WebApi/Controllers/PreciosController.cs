using MasterNet.Application.Precios.GetPrecios;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using static MasterNet.Application.Precios.GetPrecios.GetPreciosQuery;

namespace MasterNet.WebApi.Controllers;

[ApiController]
[Route("api/precios")]
public class PreciosController : ControllerBase
{
  private readonly ISender _sender;

  public PreciosController(ISender sender)
  {
    _sender = sender;
  }

  [HttpGet]
  public async Task<IActionResult> PaginationPrecios([FromQuery] GetPreciosRequest request, CancellationToken cancellationToken)
  {
    var query = new GetPreciosQueryRequest { PreciosRequest = request };
    var result = await _sender.Send(query, cancellationToken);

    return result.IsSuccess ? Ok(result.Value) : NotFound();
  }
}