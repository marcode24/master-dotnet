using System.Text;
using MasterNet.Application.Interfaces;
using MasterNet.Infrastructure.Security;
using MasterNet.Persistence;
using MasterNet.Persistence.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;

namespace MasterNet.WebApi.Extensions;

public static class IdentityServiceExtensions
{
  public static IServiceCollection AddIdentityService(this IServiceCollection services, IConfiguration configuration)
  {
    services.AddIdentityCore<AppUser>(options =>
      {
        options.Password.RequireNonAlphanumeric = false;
        options.User.RequireUniqueEmail = true;
      })
      .AddRoles<IdentityRole>()
      .AddEntityFrameworkStores<MasterNetDbContext>();

    services.AddScoped<ITokenService, TokenService>();
    services.AddScoped<IUserAccesor, UserAccessor>();

    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["TokenKey"]!));

    services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
      .AddJwtBearer(options =>
      {
        options.TokenValidationParameters = new TokenValidationParameters
        {
          ValidateIssuerSigningKey = true,
          IssuerSigningKey = key,
          ValidateIssuer = false,
          ValidateAudience = false
        };
      });

    return services;
  }
}