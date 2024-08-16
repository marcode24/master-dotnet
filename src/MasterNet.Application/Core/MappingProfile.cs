using AutoMapper;
using MasterNet.Application.Calificaciones.GetCalificaciones;
using MasterNet.Application.Cursos.GetCurso;
using MasterNet.Application.Instructores.GetInstructores;
using MasterNet.Application.Photos.GetPhoto;
using MasterNet.Application.Precios.GetPrecios;
using MasterNet.Domain;

namespace MasterNet.Application.Core;

public class MappingProfile : Profile
{
  public MappingProfile()
  {
    CreateMap<Curso, CursoResponse>();
    CreateMap<Photo, PhotoResponse>();
    CreateMap<Precio, PrecioResponse>();

    CreateMap<Instructor, InstructorResponse>()
      .ForMember(dest => dest.Apellido, src => src.MapFrom(doc => doc.Apeliidos));

    CreateMap<Calificacion, CalificacionResponse>()
      .ForMember(dest => dest.NombreCurso, src => src.MapFrom(doc => doc.Curso!.Titulo));
  }
}