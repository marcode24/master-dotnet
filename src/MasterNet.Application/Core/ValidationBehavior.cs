using FluentValidation;
using MediatR;

namespace MasterNet.Application.Core;

public sealed class ValidationBehavior<TRequest, TResponse>
: IPipelineBehavior<TRequest, TResponse> where TRequest : ICommandBase
{
  private readonly IEnumerable<IValidator<TRequest>> _validators;

  public ValidationBehavior(IEnumerable<IValidator<TRequest>> validators)
  {
    _validators = validators;
  }

  public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
  {
    var context = new ValidationContext<TRequest>(request);
    var validationFailures = await Task.WhenAll(
      _validators.Select(v => v.ValidateAsync(context, cancellationToken))
    );

    var errors = validationFailures
      .Where(validationResult => !validationResult.IsValid)
      .SelectMany(validationResult => validationResult.Errors)
      .Select(validationFailure => new ValidationError(
        validationFailure.PropertyName,
        validationFailure.ErrorMessage
      ))
      .ToList();

    if (errors.Count != 0)
      throw new ValidationException(errors);

    return await next();
  }
}