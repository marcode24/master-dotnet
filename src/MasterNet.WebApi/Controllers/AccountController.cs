using MasterNet.Application.Accounts;
using MasterNet.Application.Accounts.Login;
using MasterNet.Application.Accounts.Register;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static MasterNet.Application.Accounts.Login.LoginCommand;
using static MasterNet.Application.Accounts.Register.RegisterCommand;

namespace MasterNet.WebApi.Controllers;

[ApiController]
[Route("api/account")]
public class AccountController : ControllerBase
{
  private readonly ISender _sender;

  public AccountController(ISender sender)
  {
    _sender = sender;
  }

  [AllowAnonymous]
  [HttpPost("login")]
  [ProducesResponseType(StatusCodes.Status200OK)]
  public async Task<ActionResult<Profile>> Login([FromBody] LoginRequest request, CancellationToken cancellationToken)
  {
    var command = new LoginCommandRequest(request);
    var resultado = await _sender.Send(command, cancellationToken);
    return resultado.IsSuccess
      ? Ok(resultado.Value)
      : Unauthorized(resultado.Error);
  }

  [AllowAnonymous]
  [HttpPost("register")]
  [ProducesResponseType(StatusCodes.Status200OK)]
  public async Task<ActionResult<Profile>> Register([FromBody] RegisterRequest request, CancellationToken cancellationToken)
  {
    var command = new RegisterCommandRequest(request);
    var resultado = await _sender.Send(command, cancellationToken);
    return resultado.IsSuccess
      ? Ok(resultado.Value)
      : BadRequest(resultado.Error);
  }
}