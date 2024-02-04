using MediatR;
using StudyCenter.Domain.Models;

namespace StudyCenter.Service.UseCases.Students.Queries
{
    public class GetAllStudentsQuery:IRequest<List<Student>>
    {
    }
}
