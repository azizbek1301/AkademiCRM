using MediatR;
using StudyCenter.Domain.Models;

namespace StudyCenter.Service.UseCases.Teachers.Queries
{
    public class GetAllTeacherQuery : IRequest<List<Teacher>>
    {

    }
}
