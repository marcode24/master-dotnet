using FluentValidation;

namespace MasterNet.Application.Cursos.CursoUpdate;

public class CursoUpdateValidator : AbstractValidator<CursoUpdateRequest>
{
  public CursoUpdateValidator()
  {
    RuleFor(x => x.Titulo)
      .NotEmpty()
      .WithMessage("El título es requerido");

    RuleFor(x => x.Descripcion)
      .NotEmpty()
      .WithMessage("La descripción es requerida");

    RuleFor(x => x.FechaPublicacion)
      .NotEmpty()
      .WithMessage("La fecha de publicación es requerida");
  }
}