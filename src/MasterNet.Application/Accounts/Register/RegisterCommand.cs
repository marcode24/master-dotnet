using FluentValidation;
using MasterNet.Application.Core;
using MasterNet.Application.Interfaces;
using MasterNet.Domain;
using MasterNet.Persistence.Models;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MasterNet.Application.Accounts.Register;

public class RegisterCommand
{
  public record RegisterCommandRequest(RegisterRequest RegisterRequest) : IRequest<Result<Profile>>;

  internal class RegisterCommandHandler : IRequestHandler<RegisterCommandRequest, Result<Profile>>
  {
    private readonly UserManager<AppUser> _userManager;
    private readonly ITokenService _tokenService;

    public RegisterCommandHandler(UserManager<AppUser> userManager, ITokenService tokenService)
    {
      _userManager = userManager;
      _tokenService = tokenService;
    }

    public async Task<Result<Profile>> Handle(RegisterCommandRequest request, CancellationToken cancellationToken)
    {
      if (await _userManager.Users.AnyAsync(x => x.Email == request.RegisterRequest.Email, cancellationToken: cancellationToken))
        return Result<Profile>.Failure("Email ya está en uso");

      if (await _userManager.Users.AnyAsync(x => x.UserName == request.RegisterRequest.Username, cancellationToken: cancellationToken))
        return Result<Profile>.Failure("Username ya está en uso");

      var user = new AppUser
      {
        Id = Guid.NewGuid().ToString(),
        NombreCompleto = request.RegisterRequest.NombreCompleto,
        UserName = request.RegisterRequest.Username,
        Email = request.RegisterRequest.Email,
        Carrera = request.RegisterRequest.Carrera
      };

      var result = await _userManager.CreateAsync(user, request.RegisterRequest.Password!);

      if (result.Succeeded)
      {

        await _userManager.AddToRoleAsync(user, CustomRoles.CLIENTE);

        var profile = new Profile
        {
          Email = user.Email,
          NombreCompleto = user.NombreCompleto,
          Token = await _tokenService.CreateToken(user),
          Username = user.UserName
        };

        return Result<Profile>.Success(profile);
      }

      return Result<Profile>.Failure("Error al registrar usuario");
    }
  }

  public class RegisterCommandRequestValidator : AbstractValidator<RegisterCommandRequest>
  {
    public RegisterCommandRequestValidator()
    {
      RuleFor(x => x.RegisterRequest).SetValidator(new RegisterValidator());
    }
  }
}