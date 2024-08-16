namespace MasterNet.Application.Photos.GetPhoto;

public record PhotoResponse(
  Guid? Id,
  string? Url,
  Guid? CursoId
)
{
  public PhotoResponse() : this(null, null, null) { }
}