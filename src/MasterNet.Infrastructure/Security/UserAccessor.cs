using System.Security.Claims;
using MasterNet.Application.Interfaces;
using Microsoft.AspNetCore.Http;

namespace MasterNet.Infrastructure.Security;

public class UserAccessor : IUserAccesor
{
  private readonly IHttpContextAccessor _httpContextAccessor;

  public UserAccessor(IHttpContextAccessor httpContextAccessor)
  {
    _httpContextAccessor = httpContextAccessor;
  }

  public string? GetEmail()
  {
    return _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.Email);
  }

  public string? GetUsername()
  {
    return _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.Name);
  }
}