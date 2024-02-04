using MediatR;
using StudyCenter.Domain.Models;

namespace StudyCenter.Service.UseCases.TeacherClasses.Queries
{
    public class GetTeacherClassesByIdQuery : IRequest<TeacherClass>
    {
        public int Id { get; set; }
    }
}
