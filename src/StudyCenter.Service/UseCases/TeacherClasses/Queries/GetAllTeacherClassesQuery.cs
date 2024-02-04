using MediatR;
using StudyCenter.Domain.Models;

namespace StudyCenter.Service.UseCases.TeacherClasses.Queries
{
    public class GetAllTeacherClassesQuery:IRequest<List<TeacherClass>>
    {
    }
}
