using Microsoft.OpenApi.Models;

namespace MasterNet.WebApi.Extensions;

public static class SwaggerServiceExtensions
{
  private static readonly string[] value = new[] { "Bearer" };

  public static IServiceCollection AddSwaggerDocumentation(this IServiceCollection services)
  {
    services.AddEndpointsApiExplorer();
    services.AddSwaggerGen(c =>
    {
      var securitySchema = new OpenApiSecurityScheme
      {
        Description = "JWT Authorization Bearer Schema",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.Http,
        Scheme = "Bearer",
        Reference = new OpenApiReference
        {
          Type = ReferenceType.SecurityScheme,
          Id = "Bearer"
        }
      };

      c.AddSecurityDefinition("Bearer", securitySchema);

      var securityRequirement = new OpenApiSecurityRequirement
      {
        { securitySchema, value }
      };

      c.AddSecurityRequirement(securityRequirement);
    });

    return services;
  }

  public static IApplicationBuilder UseSwaggerDocumentation(this IApplicationBuilder app)
  {
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
      c.SwaggerEndpoint("/swagger/v1/swagger.json", "MasterNet API");
    });

    return app;
  }
}