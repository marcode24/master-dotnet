namespace MasterNet.Application.Accounts.GetCurrentUser;

public class GetCurrentUserRequest
{
  public GetCurrentUserRequest(string? email)
  {
    Email = email;
  }

  public string? Email { get; set; }
}