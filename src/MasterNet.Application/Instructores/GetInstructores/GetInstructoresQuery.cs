namespace MasterNet.Application.Instructores.GetInstructores;

public record InstructorResponse(
  Guid? Id,
  string? Nombre,
  string? Apellido,
  string? Grado
)
{
  public InstructorResponse() : this(null, null, null, null) { }
}