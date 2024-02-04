using MediatR;
using StudyCenter.Domain.Dtos.Unpaid_Student;

namespace StudyCenter.Service.UseCases.Unpaid_Students.Command
{
    public class CreateUnpaidStudentCommand : UnpaidStudentCreateDto, IRequest<int>
    {
    }
}
