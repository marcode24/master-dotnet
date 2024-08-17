using MasterNet.Application.Core;

namespace MasterNet.Application.Calificaciones.GetCalificaciones;

public class GetCalificacionesRequest : PagingParams
{
  public string? Alumno { get; set; }
  public Guid? CursoId { get; set; }
}