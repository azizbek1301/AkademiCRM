using MediatR;
using StudyCenter.Domain.Models;

namespace StudyCenter.Service.UseCases.Unpaid_Students.Queries
{
    public class GetAllUnpaidStudentQuery : IRequest<List<Unpaid_Student>>
    {
    }
}
