using MasterNet.Domain;

namespace MasterNet.WebApi.Extensions;

public static class PoliciesConfiguration
{
  public static IServiceCollection AddPoliciesServices(this IServiceCollection services)
  {
    services.AddAuthorization(options =>
    {
      options.AddPolicy(
        PolicyMaster.CURSO_READ,
        policy => policy.RequireAssertion(
          context => context.User.HasClaim(
            c => c.Type == CustomClaims.POLICIES && c.Value == PolicyMaster.CURSO_READ
          )
        )
      );

      options.AddPolicy(
        PolicyMaster.CURSO_WRITE,
        policy => policy.RequireAssertion(
          context => context.User.HasClaim(
            c => c.Type == CustomClaims.POLICIES && c.Value == PolicyMaster.CURSO_WRITE
          )
        )
      );

      options.AddPolicy(
        PolicyMaster.CURSO_UPDATE,
        policy => policy.RequireAssertion(
          context => context.User.HasClaim(
            c => c.Type == CustomClaims.POLICIES && c.Value == PolicyMaster.CURSO_UPDATE
          )
        )
      );

      options.AddPolicy(
        PolicyMaster.CURSO_DELETE,
        policy => policy.RequireAssertion(
          context => context.User.HasClaim(
            c => c.Type == CustomClaims.POLICIES && c.Value == PolicyMaster.CURSO_DELETE
          )
        )
      );

      options.AddPolicy(
        PolicyMaster.INSTRUCTOR_CREATE,
        policy => policy.RequireAssertion(
          context => context.User.HasClaim(
            c => c.Type == CustomClaims.POLICIES && c.Value == PolicyMaster.INSTRUCTOR_CREATE
          )
        )
      );

      options.AddPolicy(
        PolicyMaster.INSTRUCTOR_UPDATE,
        policy => policy.RequireAssertion(
          context => context.User.HasClaim(
            c => c.Type == CustomClaims.POLICIES && c.Value == PolicyMaster.INSTRUCTOR_UPDATE
          )
        )
      );

      options.AddPolicy(
        PolicyMaster.INSTRUCTOR_READ,
        policy => policy.RequireAssertion(
          context => context.User.HasClaim(
            c => c.Type == CustomClaims.POLICIES && c.Value == PolicyMaster.INSTRUCTOR_READ
          )
        )
      );

      options.AddPolicy(
        PolicyMaster.COMENTARIO_READ,
        policy => policy.RequireAssertion(
          context => context.User.HasClaim(
            c => c.Type == CustomClaims.POLICIES && c.Value == PolicyMaster.COMENTARIO_READ
          )
        )
      );

      options.AddPolicy(
        PolicyMaster.COMENTARIO_CREATE,
        policy => policy.RequireAssertion(
          context => context.User.HasClaim(
            c => c.Type == CustomClaims.POLICIES && c.Value == PolicyMaster.COMENTARIO_CREATE
          )
        )
      );

      options.AddPolicy(
        PolicyMaster.COMENTARIO_DELETE,
        policy => policy.RequireAssertion(
          context => context.User.HasClaim(
            c => c.Type == CustomClaims.POLICIES && c.Value == PolicyMaster.COMENTARIO_DELETE
          )
        )
      );
    });

    return services;
  }
}