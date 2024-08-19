using FluentValidation;

namespace MasterNet.Application.Accounts.Login;

public class LoginValidator : AbstractValidator<LoginRequest>
{
  public LoginValidator()
  {
    RuleFor(x => x.Email)
      .NotEmpty()
      .WithMessage("El email es requerido")
      .EmailAddress()
      .WithMessage("El email no es válido");

    RuleFor(x => x.Password)
      .NotEmpty()
      .WithMessage("La contraseña es requerida");
  }
}