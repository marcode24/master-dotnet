using MasterNet.Application.Interfaces;
using MasterNet.Infrastructure.Security;
using MasterNet.Persistence;
using MasterNet.Persistence.Models;
using Microsoft.AspNetCore.Identity;

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

    return services;
  }
}