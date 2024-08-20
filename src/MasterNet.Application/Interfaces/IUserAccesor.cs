namespace MasterNet.Application.Interfaces;

public interface IUserAccesor
{
  string? GetUsername();
  string? GetEmail();
}