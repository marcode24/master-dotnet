using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using MasterNet.Application.Interfaces;
using MasterNet.Domain;
using MasterNet.Persistence;
using MasterNet.Persistence.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace MasterNet.Infrastructure.Security;

public class TokenService : ITokenService
{
  private readonly MasterNetDbContext _context;
  private readonly IConfiguration _configuration;

  public TokenService(MasterNetDbContext context, IConfiguration configuration)
  {
    _context = context;
    _configuration = configuration;
  }

  public async Task<string> CreateToken(AppUser user)
  {
    var policies = await _context.Database.SqlQuery<string>($@"
      SELECT
        aspr.ClaimValue
      FROM AspNetUsers a
        LEFT JOIN AspNetUserRoles ar
          ON a.Id = ar.UserId
        LEFT JOIN AspNetRoleClaims aspr
          ON ar.RoleId = aspr.RoleId
        WHERE a.Id = {user.Id}
    ").ToListAsync();

    var claims = new List<Claim> {
      new(ClaimTypes.Name, user.UserName!),
      new(ClaimTypes.NameIdentifier, user.Id),
      new(ClaimTypes.Email, user.Email!)
    };

    foreach (var policy in policies)
    {
      if (policy is not null)
        claims.Add(new Claim(CustomClaims.POLICIES, policy));
    }

    var credentials = new SigningCredentials(
      new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["TokenKey"]!)),
      SecurityAlgorithms.HmacSha256
    );

    var tokenDescriptor = new SecurityTokenDescriptor
    {
      Subject = new ClaimsIdentity(claims),
      Expires = DateTime.UtcNow.AddDays(7),
      SigningCredentials = credentials
    };

    var tokenHandler = new JwtSecurityTokenHandler();
    var token = tokenHandler.CreateToken(tokenDescriptor);

    return tokenHandler.WriteToken(token);
  }
}
