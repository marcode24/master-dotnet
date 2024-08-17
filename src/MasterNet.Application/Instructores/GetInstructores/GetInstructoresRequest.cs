using MasterNet.Application.Core;

namespace MasterNet.Application.Instructores.GetInstructores;

public class GetInstructoresRequest : PagingParams
{
  public string? Nombre { get; set; }
  public string? Apellido { get; set; }
}